Imports System.Runtime.InteropServices
Imports System.Drawing

Public Class FileIconHelper
    <DllImport("shell32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SHGetFileInfo(
        pszPath As String,
        dwFileAttributes As Integer,
        ByRef psfi As SHFILEINFO,
        cbFileInfo As Integer,
        uFlags As Integer
    ) As IntPtr
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)>
    Private Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As Integer
        Public dwAttributes As UInteger
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
        Public szTypeName As String
    End Structure

    Private Const SHGFI_ICON As Integer = &H100
    Private Const SHGFI_USEFILEATTRIBUTES As Integer = &H10
    Private Const FILE_ATTRIBUTE_NORMAL As Integer = &H80

    Public Shared Function GetDefaultIconByExtension(extension As String) As Icon
        Dim shinfo As New SHFILEINFO()
        Dim result As IntPtr = SHGetFileInfo(extension, FILE_ATTRIBUTE_NORMAL, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_USEFILEATTRIBUTES)
        If shinfo.hIcon = IntPtr.Zero Then
            Return SystemIcons.WinLogo
        Else
            Dim icon As Icon = Icon.FromHandle(shinfo.hIcon)
            Dim clonedIcon As Icon = CType(icon.Clone(), Icon)
            DestroyIcon(shinfo.hIcon)
            Return clonedIcon
        End If
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function DestroyIcon(hIcon As IntPtr) As Boolean
    End Function
End Class