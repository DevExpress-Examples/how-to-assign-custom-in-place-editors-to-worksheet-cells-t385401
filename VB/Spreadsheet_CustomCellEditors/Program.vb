﻿Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel

Namespace Spreadsheet_CustomCellEditors
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			DevExpress.Skins.SkinManager.EnableFormSkins()
			DevExpress.UserSkins.BonusSkins.Register()
			UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful")

			Application.Run(New Form1())
		End Sub
	End Module
End Namespace