Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Media

Public Class ibrahimcelik

    Private Sub ibrahimcelik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        player.Stream = My.Resources.ibrahimcelik
    End Sub

    'Software Developer IBRAHIM CELIK
    'Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk
    'yo 19

    <StructLayout(LayoutKind.Sequential)>
    Public Structure UserColorPreference
        Public cbSize As Integer
        Public Color As Integer
        Public Intensity As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure DWMColorizationParams
        Public ColorizationColor As UInteger
        Public ColorizationAfterglow As Integer
        Public ColorizationColorBalance As Integer
        Public ColorizationAfterglowBalance As Integer
        Public ColorizationBlurBalance As Integer
        Public ColorizationGlassReflectionIntensity As Integer
        Public ColorizationOpaqueBlend As Integer
    End Structure

    <DllImport("uxtheme.dll", EntryPoint:="#122")>
    Public Shared Function SetUserColorPreference(ByRef userColor As UserColorPreference, uygula As Boolean) As Integer
    End Function

    <DllImport("dwmapi.dll", EntryPoint:="#131")>
    Public Shared Function DwmSetColorizationParameters(ByRef params As DWMColorizationParams, unknown As Boolean) As Integer
    End Function

    Public Shared Sub SetWindowColor(color As Color)
        Dim userColor As New UserColorPreference With {
            .cbSize = Marshal.SizeOf(GetType(UserColorPreference)),
            .Color = ColorTranslator.ToWin32(color),
            .Intensity = 100
        }
        SetUserColorPreference(userColor, True)
    End Sub

    Dim player As New SoundPlayer()



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim random As New Random()
        Dim color As Color = color.FromArgb(random.Next(256), random.Next(256), random.Next(256))
        GroupBox1.ForeColor = color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        renkinfobtn.FillColor = Button1.FillColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        renkinfobtn.FillColor = Button2.FillColor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        renkinfobtn.FillColor = Button3.FillColor
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        renkinfobtn.FillColor = Button4.FillColor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        renkinfobtn.FillColor = Button5.FillColor
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        renkinfobtn.FillColor = Button6.FillColor
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        renkinfobtn.FillColor = Button7.FillColor
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        renkinfobtn.FillColor = Button8.FillColor
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        renkinfobtn.FillColor = Button9.FillColor
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        renkinfobtn.FillColor = Button10.FillColor
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        renkinfobtn.FillColor = Button11.FillColor
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        renkinfobtn.FillColor = Button12.FillColor
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        renkinfobtn.FillColor = Button13.FillColor
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        renkinfobtn.FillColor = Button14.FillColor
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        renkinfobtn.FillColor = Button15.FillColor
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        renkinfobtn.FillColor = Button16.FillColor
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        renkinfobtn.FillColor = Button17.FillColor
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        renkinfobtn.FillColor = Button18.FillColor
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        renkinfobtn.FillColor = Button19.FillColor
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        renkinfobtn.FillColor = Button20.FillColor
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        renkinfobtn.FillColor = Button21.FillColor
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        renkinfobtn.FillColor = Button22.FillColor
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        renkinfobtn.FillColor = Button23.FillColor
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        renkinfobtn.FillColor = Button24.FillColor
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        renkinfobtn.FillColor = Button25.FillColor
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        renkinfobtn.FillColor = Button26.FillColor
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        renkinfobtn.FillColor = Button27.FillColor
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        renkinfobtn.FillColor = Button28.FillColor
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        renkinfobtn.FillColor = Button29.FillColor
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        renkinfobtn.FillColor = Button30.FillColor
    End Sub

    Private Sub baslatGradientButton1_Click(sender As Object, e As EventArgs) Handles baslatGradientButton1.Click
        SetWindowColor(renkinfobtn.FillColor)
    End Sub

    Private Sub colorGradientButton1_Click(sender As Object, e As EventArgs) Handles colorGradientButton1.Click
        Dim renkDialog As New ColorDialog()
        If renkDialog.ShowDialog() = DialogResult.OK Then
            renkinfobtn.FillColor = renkDialog.Color
        End If
    End Sub

    Private Sub birincipage_Click(sender As Object, e As EventArgs) Handles birincipage.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub ikincipage_Click(sender As Object, e As EventArgs) Handles ikincipage.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub ucuncupage_Click(sender As Object, e As EventArgs) Handles ucuncupage.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub dorduncupage_Click(sender As Object, e As EventArgs) Handles dorduncupage.Click
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub Instagrambtn_Click(sender As Object, e As EventArgs) Handles Instagrambtn.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/softwaredevic/p/C2pOtE4MN10/")
        MsgBox("Instagram : @softwaredevic")
    End Sub

    Private Sub renkinfobtn_Click(sender As Object, e As EventArgs) Handles renkinfobtn.Click
        Me.Close()
    End Sub

    Private Sub Switch1_Click1(sender As Object, e As EventArgs) Handles Switch1.Click

        If Switch1.Checked = True Then
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", True)
            key.SetValue("ColorPrevalence", 1)
        End If

        If Switch1.Checked = False Then
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", True)
            key.SetValue("ColorPrevalence", 0)
        End If

    End Sub

    Private Sub Switch2_Click1(sender As Object, e As EventArgs) Handles Switch2.Click

        If Switch2.Checked = True Then

            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", True)
            key.SetValue("EnableTransparency", 1)


            Dim key2 As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\DWM", True)
            key2.SetValue("ColorPrevalence", 1)


        End If

        If Switch2.Checked = False Then

            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", True)
            key.SetValue("EnableTransparency", 0)

            Dim key2 As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\DWM", True)
            key2.SetValue("ColorPrevalence", 0)



        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        player.Play()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Computer.Clipboard.SetText("3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk")
        MsgBox("YOU COPIED IBRAHIM CELIK IS BITCOIN ADDRESS")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/@devibrahimcelik")
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        System.Diagnostics.Process.Start("https://github.com/SoftwareDEVibrahimcelik")
    End Sub

    Private Sub Buttom34_Click(sender As Object, e As EventArgs) Handles Buttom34.Click
        System.Diagnostics.Process.Start("https://store.steampowered.com/search/?publisher=softwaredevic&ndl=1")
    End Sub


    'Software Developer IBRAHIM CELIK
    'Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk
    'yo 19


End Class