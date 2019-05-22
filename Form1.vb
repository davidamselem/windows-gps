' **************************************************************************
' ****
' ****   GPS.NET Visualization Tools Example One
' ****   A Complete Demonstration of GPS Functionality
' ****
' ****
' ****   For assistance with your GPS device or for troubleshooting:
' ****
' ****          http://www.gpsdotnet.com/support
' ****          support@gpsdotnet.com
' ****
' ****   This source code is considered public domain and may be re-used
' ****   in your own applications.
' ****
' *************************************************************************
Imports StormSource.GPS

Public Class Form1
	Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()

		'Add any initialization after the InitializeComponent() call

	End Sub

	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	Friend WithEvents StartButton As System.Windows.Forms.Button
	Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
	Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
	Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
	Friend WithEvents Latitude As System.Windows.Forms.Label
	Friend WithEvents Longitude As System.Windows.Forms.Label
	Friend WithEvents Direction As System.Windows.Forms.Label
	Friend WithEvents UTCTime As System.Windows.Forms.Label
	Friend WithEvents Altitude As System.Windows.Forms.Label
	Friend WithEvents Speed As System.Windows.Forms.Label
	Friend WithEvents Bearing As System.Windows.Forms.Label
	Friend WithEvents SatelliteList As System.Windows.Forms.ListView
	Friend WithEvents SatelliteID As System.Windows.Forms.ColumnHeader
	Friend WithEvents SatelliteElevation As System.Windows.Forms.ColumnHeader
	Friend WithEvents SatelliteAzimuth As System.Windows.Forms.ColumnHeader
	Friend WithEvents SatelliteSignalStrength As System.Windows.Forms.ColumnHeader
	Friend WithEvents StopButton As System.Windows.Forms.Button
	Friend WithEvents Sentences As System.Windows.Forms.ListBox
	Friend WithEvents LocalTime As System.Windows.Forms.Label
	Friend WithEvents FixStatus As System.Windows.Forms.Label
	Friend WithEvents FixObtained As System.Windows.Forms.Label
	Friend WithEvents FixQuality As System.Windows.Forms.Label
	Friend WithEvents UnrecognizedSentences As System.Windows.Forms.ListBox
	Friend WithEvents PDOP As System.Windows.Forms.Label
	Friend WithEvents VDOP As System.Windows.Forms.Label
	Friend WithEvents HDOP As System.Windows.Forms.Label
	Friend WithEvents MagneticVariation As System.Windows.Forms.Label
	Friend WithEvents ActiveSatellites As System.Windows.Forms.Label
	Friend WithEvents FixedSatellites As System.Windows.Forms.Label
	Friend WithEvents COMPort As System.Windows.Forms.ComboBox
	Friend WithEvents LocalTimeTimer As System.Timers.Timer
	Friend WithEvents TrackedSatellites As System.Windows.Forms.Label
	Friend WithEvents FixMode As System.Windows.Forms.Label
	Friend WithEvents FixMethod As System.Windows.Forms.Label
	Friend WithEvents chkEnableRotation As System.Windows.Forms.CheckBox
	Friend WithEvents chkShowPRCNumbers As System.Windows.Forms.CheckBox
	Friend WithEvents chkShowCompass As System.Windows.Forms.CheckBox
	Friend WithEvents lblFixMethod As System.Windows.Forms.Label
	Friend WithEvents lblTrackedSatellites As System.Windows.Forms.Label
	Friend WithEvents lblActiveSatellites As System.Windows.Forms.Label
	Friend WithEvents lblMagneticVariation As System.Windows.Forms.Label
	Friend WithEvents lblPDOP As System.Windows.Forms.Label
	Friend WithEvents lblVDOP As System.Windows.Forms.Label
	Friend WithEvents lblHDOP As System.Windows.Forms.Label
	Friend WithEvents lblFixQuality As System.Windows.Forms.Label
	Friend WithEvents lblFixStatus As System.Windows.Forms.Label
	Friend WithEvents lblFixObtained As System.Windows.Forms.Label
	Friend WithEvents lblFixMode As System.Windows.Forms.Label
	Friend WithEvents lblLocalTime As System.Windows.Forms.Label
	Friend WithEvents lblSpeed As System.Windows.Forms.Label
	Friend WithEvents lblFixedSatellites As System.Windows.Forms.Label
	Friend WithEvents lblGPSTime As System.Windows.Forms.Label
	Friend WithEvents lblDirection As System.Windows.Forms.Label
	Friend WithEvents lblBearing As System.Windows.Forms.Label
	Friend WithEvents lblAltitude As System.Windows.Forms.Label
	Friend WithEvents lblLongitude As System.Windows.Forms.Label
	Friend WithEvents lblLatitude As System.Windows.Forms.Label
	Friend WithEvents lblRecognizedSentences As System.Windows.Forms.Label
	Friend WithEvents lblUnrecognizedSentences As System.Windows.Forms.Label
	Friend WithEvents SatelliteViewer1 As StormSource.GPS.Controls.SatelliteViewer
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", ""}, -1)
		Me.StartButton = New System.Windows.Forms.Button()
		Me.StopButton = New System.Windows.Forms.Button()
		Me.StatusBar = New System.Windows.Forms.StatusBar()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.FixMethod = New System.Windows.Forms.Label()
		Me.lblFixMethod = New System.Windows.Forms.Label()
		Me.TrackedSatellites = New System.Windows.Forms.Label()
		Me.lblTrackedSatellites = New System.Windows.Forms.Label()
		Me.FixedSatellites = New System.Windows.Forms.Label()
		Me.lblActiveSatellites = New System.Windows.Forms.Label()
		Me.MagneticVariation = New System.Windows.Forms.Label()
		Me.lblMagneticVariation = New System.Windows.Forms.Label()
		Me.PDOP = New System.Windows.Forms.Label()
		Me.lblPDOP = New System.Windows.Forms.Label()
		Me.VDOP = New System.Windows.Forms.Label()
		Me.lblVDOP = New System.Windows.Forms.Label()
		Me.HDOP = New System.Windows.Forms.Label()
		Me.lblHDOP = New System.Windows.Forms.Label()
		Me.FixQuality = New System.Windows.Forms.Label()
		Me.lblFixQuality = New System.Windows.Forms.Label()
		Me.FixStatus = New System.Windows.Forms.Label()
		Me.lblFixStatus = New System.Windows.Forms.Label()
		Me.FixObtained = New System.Windows.Forms.Label()
		Me.lblFixObtained = New System.Windows.Forms.Label()
		Me.FixMode = New System.Windows.Forms.Label()
		Me.lblFixMode = New System.Windows.Forms.Label()
		Me.LocalTime = New System.Windows.Forms.Label()
		Me.lblLocalTime = New System.Windows.Forms.Label()
		Me.Speed = New System.Windows.Forms.Label()
		Me.lblSpeed = New System.Windows.Forms.Label()
		Me.ActiveSatellites = New System.Windows.Forms.Label()
		Me.lblFixedSatellites = New System.Windows.Forms.Label()
		Me.UTCTime = New System.Windows.Forms.Label()
		Me.lblGPSTime = New System.Windows.Forms.Label()
		Me.Direction = New System.Windows.Forms.Label()
		Me.lblDirection = New System.Windows.Forms.Label()
		Me.Bearing = New System.Windows.Forms.Label()
		Me.Altitude = New System.Windows.Forms.Label()
		Me.Longitude = New System.Windows.Forms.Label()
		Me.Latitude = New System.Windows.Forms.Label()
		Me.lblBearing = New System.Windows.Forms.Label()
		Me.lblAltitude = New System.Windows.Forms.Label()
		Me.lblLongitude = New System.Windows.Forms.Label()
		Me.lblLatitude = New System.Windows.Forms.Label()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.SatelliteViewer1 = New StormSource.GPS.Controls.SatelliteViewer()
		Me.chkShowCompass = New System.Windows.Forms.CheckBox()
		Me.chkShowPRCNumbers = New System.Windows.Forms.CheckBox()
		Me.chkEnableRotation = New System.Windows.Forms.CheckBox()
		Me.SatelliteList = New System.Windows.Forms.ListView()
		Me.SatelliteID = New System.Windows.Forms.ColumnHeader()
		Me.SatelliteElevation = New System.Windows.Forms.ColumnHeader()
		Me.SatelliteAzimuth = New System.Windows.Forms.ColumnHeader()
		Me.SatelliteSignalStrength = New System.Windows.Forms.ColumnHeader()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.lblRecognizedSentences = New System.Windows.Forms.Label()
		Me.lblUnrecognizedSentences = New System.Windows.Forms.Label()
		Me.UnrecognizedSentences = New System.Windows.Forms.ListBox()
		Me.Sentences = New System.Windows.Forms.ListBox()
		Me.COMPort = New System.Windows.Forms.ComboBox()
		Me.LocalTimeTimer = New System.Timers.Timer()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		CType(Me.LocalTimeTimer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'StartButton
		'
		Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.StartButton.Location = New System.Drawing.Point(417, 39)
		Me.StartButton.Name = "StartButton"
		Me.StartButton.Size = New System.Drawing.Size(72, 24)
		Me.StartButton.TabIndex = 0
		Me.StartButton.Text = "Start"
		'
		'StopButton
		'
		Me.StopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.StopButton.Enabled = False
		Me.StopButton.Location = New System.Drawing.Point(417, 69)
		Me.StopButton.Name = "StopButton"
		Me.StopButton.Size = New System.Drawing.Size(72, 24)
		Me.StopButton.TabIndex = 1
		Me.StopButton.Text = "Stop"
		'
		'StatusBar
		'
		Me.StatusBar.Location = New System.Drawing.Point(0, 581)
		Me.StatusBar.Name = "StatusBar"
		Me.StatusBar.Size = New System.Drawing.Size(502, 18)
		Me.StatusBar.TabIndex = 3
		Me.StatusBar.Text = "Ready"
		'
		'TabControl1
		'
		Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Location = New System.Drawing.Point(9, 9)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(396, 561)
		Me.TabControl1.TabIndex = 4
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.FixMethod)
		Me.TabPage1.Controls.Add(Me.lblFixMethod)
		Me.TabPage1.Controls.Add(Me.TrackedSatellites)
		Me.TabPage1.Controls.Add(Me.lblTrackedSatellites)
		Me.TabPage1.Controls.Add(Me.FixedSatellites)
		Me.TabPage1.Controls.Add(Me.lblActiveSatellites)
		Me.TabPage1.Controls.Add(Me.MagneticVariation)
		Me.TabPage1.Controls.Add(Me.lblMagneticVariation)
		Me.TabPage1.Controls.Add(Me.PDOP)
		Me.TabPage1.Controls.Add(Me.lblPDOP)
		Me.TabPage1.Controls.Add(Me.VDOP)
		Me.TabPage1.Controls.Add(Me.lblVDOP)
		Me.TabPage1.Controls.Add(Me.HDOP)
		Me.TabPage1.Controls.Add(Me.lblHDOP)
		Me.TabPage1.Controls.Add(Me.FixQuality)
		Me.TabPage1.Controls.Add(Me.lblFixQuality)
		Me.TabPage1.Controls.Add(Me.FixStatus)
		Me.TabPage1.Controls.Add(Me.lblFixStatus)
		Me.TabPage1.Controls.Add(Me.FixObtained)
		Me.TabPage1.Controls.Add(Me.lblFixObtained)
		Me.TabPage1.Controls.Add(Me.FixMode)
		Me.TabPage1.Controls.Add(Me.lblFixMode)
		Me.TabPage1.Controls.Add(Me.LocalTime)
		Me.TabPage1.Controls.Add(Me.lblLocalTime)
		Me.TabPage1.Controls.Add(Me.Speed)
		Me.TabPage1.Controls.Add(Me.lblSpeed)
		Me.TabPage1.Controls.Add(Me.ActiveSatellites)
		Me.TabPage1.Controls.Add(Me.lblFixedSatellites)
		Me.TabPage1.Controls.Add(Me.UTCTime)
		Me.TabPage1.Controls.Add(Me.lblGPSTime)
		Me.TabPage1.Controls.Add(Me.Direction)
		Me.TabPage1.Controls.Add(Me.lblDirection)
		Me.TabPage1.Controls.Add(Me.Bearing)
		Me.TabPage1.Controls.Add(Me.Altitude)
		Me.TabPage1.Controls.Add(Me.Longitude)
		Me.TabPage1.Controls.Add(Me.Latitude)
		Me.TabPage1.Controls.Add(Me.lblBearing)
		Me.TabPage1.Controls.Add(Me.lblAltitude)
		Me.TabPage1.Controls.Add(Me.lblLongitude)
		Me.TabPage1.Controls.Add(Me.lblLatitude)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Size = New System.Drawing.Size(388, 535)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Location"
		'
		'FixMethod
		'
		Me.FixMethod.Location = New System.Drawing.Point(114, 189)
		Me.FixMethod.Name = "FixMethod"
		Me.FixMethod.Size = New System.Drawing.Size(87, 18)
		Me.FixMethod.TabIndex = 39
		Me.FixMethod.Text = "(Unknown)"
		'
		'lblFixMethod
		'
		Me.lblFixMethod.Location = New System.Drawing.Point(21, 189)
		Me.lblFixMethod.Name = "lblFixMethod"
		Me.lblFixMethod.Size = New System.Drawing.Size(87, 18)
		Me.lblFixMethod.TabIndex = 38
		Me.lblFixMethod.Text = "Fix Method:"
		'
		'TrackedSatellites
		'
		Me.TrackedSatellites.Location = New System.Drawing.Point(114, 69)
		Me.TrackedSatellites.Name = "TrackedSatellites"
		Me.TrackedSatellites.Size = New System.Drawing.Size(87, 18)
		Me.TrackedSatellites.TabIndex = 37
		Me.TrackedSatellites.Text = "(Unknown)"
		'
		'lblTrackedSatellites
		'
		Me.lblTrackedSatellites.Location = New System.Drawing.Point(21, 69)
		Me.lblTrackedSatellites.Name = "lblTrackedSatellites"
		Me.lblTrackedSatellites.Size = New System.Drawing.Size(87, 18)
		Me.lblTrackedSatellites.TabIndex = 36
		Me.lblTrackedSatellites.Text = "Tracked Sat.:"
		'
		'FixedSatellites
		'
		Me.FixedSatellites.Location = New System.Drawing.Point(114, 45)
		Me.FixedSatellites.Name = "FixedSatellites"
		Me.FixedSatellites.Size = New System.Drawing.Size(87, 18)
		Me.FixedSatellites.TabIndex = 35
		Me.FixedSatellites.Text = "(Unknown)"
		'
		'lblActiveSatellites
		'
		Me.lblActiveSatellites.Location = New System.Drawing.Point(21, 21)
		Me.lblActiveSatellites.Name = "lblActiveSatellites"
		Me.lblActiveSatellites.Size = New System.Drawing.Size(87, 18)
		Me.lblActiveSatellites.TabIndex = 34
		Me.lblActiveSatellites.Text = "Active Satellites:"
		'
		'MagneticVariation
		'
		Me.MagneticVariation.Location = New System.Drawing.Point(114, 477)
		Me.MagneticVariation.Name = "MagneticVariation"
		Me.MagneticVariation.Size = New System.Drawing.Size(87, 18)
		Me.MagneticVariation.TabIndex = 33
		Me.MagneticVariation.Text = "(Unknown)"
		'
		'lblMagneticVariation
		'
		Me.lblMagneticVariation.Location = New System.Drawing.Point(21, 477)
		Me.lblMagneticVariation.Name = "lblMagneticVariation"
		Me.lblMagneticVariation.Size = New System.Drawing.Size(87, 18)
		Me.lblMagneticVariation.TabIndex = 32
		Me.lblMagneticVariation.Text = "Magnetic Var.:"
		'
		'PDOP
		'
		Me.PDOP.Location = New System.Drawing.Point(114, 405)
		Me.PDOP.Name = "PDOP"
		Me.PDOP.Size = New System.Drawing.Size(87, 18)
		Me.PDOP.TabIndex = 31
		Me.PDOP.Text = "50.0"
		'
		'lblPDOP
		'
		Me.lblPDOP.Location = New System.Drawing.Point(21, 405)
		Me.lblPDOP.Name = "lblPDOP"
		Me.lblPDOP.Size = New System.Drawing.Size(87, 18)
		Me.lblPDOP.TabIndex = 30
		Me.lblPDOP.Text = "PDOP:"
		'
		'VDOP
		'
		Me.VDOP.Location = New System.Drawing.Point(114, 453)
		Me.VDOP.Name = "VDOP"
		Me.VDOP.Size = New System.Drawing.Size(87, 18)
		Me.VDOP.TabIndex = 29
		Me.VDOP.Text = "50.0"
		'
		'lblVDOP
		'
		Me.lblVDOP.Location = New System.Drawing.Point(21, 453)
		Me.lblVDOP.Name = "lblVDOP"
		Me.lblVDOP.Size = New System.Drawing.Size(87, 18)
		Me.lblVDOP.TabIndex = 28
		Me.lblVDOP.Text = "VDOP:"
		'
		'HDOP
		'
		Me.HDOP.Location = New System.Drawing.Point(114, 429)
		Me.HDOP.Name = "HDOP"
		Me.HDOP.Size = New System.Drawing.Size(87, 18)
		Me.HDOP.TabIndex = 27
		Me.HDOP.Text = "50.0"
		'
		'lblHDOP
		'
		Me.lblHDOP.Location = New System.Drawing.Point(21, 429)
		Me.lblHDOP.Name = "lblHDOP"
		Me.lblHDOP.Size = New System.Drawing.Size(87, 18)
		Me.lblHDOP.TabIndex = 26
		Me.lblHDOP.Text = "HDOP:"
		'
		'FixQuality
		'
		Me.FixQuality.Location = New System.Drawing.Point(114, 213)
		Me.FixQuality.Name = "FixQuality"
		Me.FixQuality.Size = New System.Drawing.Size(87, 18)
		Me.FixQuality.TabIndex = 25
		Me.FixQuality.Text = "(Unknown)"
		'
		'lblFixQuality
		'
		Me.lblFixQuality.Location = New System.Drawing.Point(21, 213)
		Me.lblFixQuality.Name = "lblFixQuality"
		Me.lblFixQuality.Size = New System.Drawing.Size(87, 18)
		Me.lblFixQuality.TabIndex = 24
		Me.lblFixQuality.Text = "Fix Quality:"
		'
		'FixStatus
		'
		Me.FixStatus.Location = New System.Drawing.Point(114, 141)
		Me.FixStatus.Name = "FixStatus"
		Me.FixStatus.Size = New System.Drawing.Size(87, 18)
		Me.FixStatus.TabIndex = 23
		Me.FixStatus.Text = "(Unknown)"
		'
		'lblFixStatus
		'
		Me.lblFixStatus.Location = New System.Drawing.Point(21, 141)
		Me.lblFixStatus.Name = "lblFixStatus"
		Me.lblFixStatus.Size = New System.Drawing.Size(87, 18)
		Me.lblFixStatus.TabIndex = 22
		Me.lblFixStatus.Text = "Fix Status:"
		'
		'FixObtained
		'
		Me.FixObtained.Location = New System.Drawing.Point(114, 237)
		Me.FixObtained.Name = "FixObtained"
		Me.FixObtained.Size = New System.Drawing.Size(249, 18)
		Me.FixObtained.TabIndex = 21
		Me.FixObtained.Text = "(Unknown)"
		'
		'lblFixObtained
		'
		Me.lblFixObtained.Location = New System.Drawing.Point(21, 237)
		Me.lblFixObtained.Name = "lblFixObtained"
		Me.lblFixObtained.Size = New System.Drawing.Size(87, 18)
		Me.lblFixObtained.TabIndex = 20
		Me.lblFixObtained.Text = "Fix Obtained:"
		'
		'FixMode
		'
		Me.FixMode.Location = New System.Drawing.Point(114, 165)
		Me.FixMode.Name = "FixMode"
		Me.FixMode.Size = New System.Drawing.Size(87, 18)
		Me.FixMode.TabIndex = 19
		Me.FixMode.Text = "(Unknown)"
		'
		'lblFixMode
		'
		Me.lblFixMode.Location = New System.Drawing.Point(21, 165)
		Me.lblFixMode.Name = "lblFixMode"
		Me.lblFixMode.Size = New System.Drawing.Size(87, 18)
		Me.lblFixMode.TabIndex = 18
		Me.lblFixMode.Text = "Fix Mode:"
		'
		'LocalTime
		'
		Me.LocalTime.Location = New System.Drawing.Point(114, 117)
		Me.LocalTime.Name = "LocalTime"
		Me.LocalTime.Size = New System.Drawing.Size(249, 18)
		Me.LocalTime.TabIndex = 17
		Me.LocalTime.Text = "(Unknown)"
		'
		'lblLocalTime
		'
		Me.lblLocalTime.Location = New System.Drawing.Point(21, 117)
		Me.lblLocalTime.Name = "lblLocalTime"
		Me.lblLocalTime.Size = New System.Drawing.Size(87, 18)
		Me.lblLocalTime.TabIndex = 16
		Me.lblLocalTime.Text = "Local Time:"
		'
		'Speed
		'
		Me.Speed.Location = New System.Drawing.Point(114, 333)
		Me.Speed.Name = "Speed"
		Me.Speed.Size = New System.Drawing.Size(87, 18)
		Me.Speed.TabIndex = 15
		Me.Speed.Text = "(Unknown)"
		'
		'lblSpeed
		'
		Me.lblSpeed.Location = New System.Drawing.Point(21, 333)
		Me.lblSpeed.Name = "lblSpeed"
		Me.lblSpeed.Size = New System.Drawing.Size(87, 18)
		Me.lblSpeed.TabIndex = 14
		Me.lblSpeed.Text = "Speed:"
		'
		'ActiveSatellites
		'
		Me.ActiveSatellites.Location = New System.Drawing.Point(114, 21)
		Me.ActiveSatellites.Name = "ActiveSatellites"
		Me.ActiveSatellites.Size = New System.Drawing.Size(87, 18)
		Me.ActiveSatellites.TabIndex = 13
		Me.ActiveSatellites.Text = "(Unknown)"
		'
		'lblFixedSatellites
		'
		Me.lblFixedSatellites.Location = New System.Drawing.Point(21, 45)
		Me.lblFixedSatellites.Name = "lblFixedSatellites"
		Me.lblFixedSatellites.Size = New System.Drawing.Size(87, 18)
		Me.lblFixedSatellites.TabIndex = 12
		Me.lblFixedSatellites.Text = "Fixed Satellites:"
		'
		'UTCTime
		'
		Me.UTCTime.Location = New System.Drawing.Point(114, 93)
		Me.UTCTime.Name = "UTCTime"
		Me.UTCTime.Size = New System.Drawing.Size(249, 18)
		Me.UTCTime.TabIndex = 11
		Me.UTCTime.Text = "(Unknown)"
		'
		'lblGPSTime
		'
		Me.lblGPSTime.Location = New System.Drawing.Point(21, 93)
		Me.lblGPSTime.Name = "lblGPSTime"
		Me.lblGPSTime.Size = New System.Drawing.Size(87, 18)
		Me.lblGPSTime.TabIndex = 10
		Me.lblGPSTime.Text = "GPS Time:"
		'
		'Direction
		'
		Me.Direction.Location = New System.Drawing.Point(114, 381)
		Me.Direction.Name = "Direction"
		Me.Direction.Size = New System.Drawing.Size(87, 18)
		Me.Direction.TabIndex = 9
		Me.Direction.Text = "(Unknown)"
		'
		'lblDirection
		'
		Me.lblDirection.Location = New System.Drawing.Point(21, 381)
		Me.lblDirection.Name = "lblDirection"
		Me.lblDirection.Size = New System.Drawing.Size(87, 18)
		Me.lblDirection.TabIndex = 8
		Me.lblDirection.Text = "Direction:"
		'
		'Bearing
		'
		Me.Bearing.Location = New System.Drawing.Point(114, 357)
		Me.Bearing.Name = "Bearing"
		Me.Bearing.Size = New System.Drawing.Size(87, 18)
		Me.Bearing.TabIndex = 7
		Me.Bearing.Text = "(Unknown)"
		'
		'Altitude
		'
		Me.Altitude.Location = New System.Drawing.Point(114, 309)
		Me.Altitude.Name = "Altitude"
		Me.Altitude.Size = New System.Drawing.Size(249, 18)
		Me.Altitude.TabIndex = 6
		Me.Altitude.Text = "0 Meters"
		'
		'Longitude
		'
		Me.Longitude.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Longitude.Location = New System.Drawing.Point(114, 285)
		Me.Longitude.Name = "Longitude"
		Me.Longitude.Size = New System.Drawing.Size(249, 18)
		Me.Longitude.TabIndex = 5
		Me.Longitude.Text = "000°00'00""W"
		'
		'Latitude
		'
		Me.Latitude.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Latitude.Location = New System.Drawing.Point(114, 261)
		Me.Latitude.Name = "Latitude"
		Me.Latitude.Size = New System.Drawing.Size(249, 18)
		Me.Latitude.TabIndex = 4
		Me.Latitude.Text = "00°00'00""N"
		'
		'lblBearing
		'
		Me.lblBearing.Location = New System.Drawing.Point(21, 357)
		Me.lblBearing.Name = "lblBearing"
		Me.lblBearing.Size = New System.Drawing.Size(87, 18)
		Me.lblBearing.TabIndex = 3
		Me.lblBearing.Text = "Bearing:"
		'
		'lblAltitude
		'
		Me.lblAltitude.Location = New System.Drawing.Point(21, 309)
		Me.lblAltitude.Name = "lblAltitude"
		Me.lblAltitude.Size = New System.Drawing.Size(87, 18)
		Me.lblAltitude.TabIndex = 2
		Me.lblAltitude.Text = "Altitude:"
		'
		'lblLongitude
		'
		Me.lblLongitude.Location = New System.Drawing.Point(21, 285)
		Me.lblLongitude.Name = "lblLongitude"
		Me.lblLongitude.Size = New System.Drawing.Size(87, 18)
		Me.lblLongitude.TabIndex = 1
		Me.lblLongitude.Text = "Longitude:"
		'
		'lblLatitude
		'
		Me.lblLatitude.Location = New System.Drawing.Point(21, 261)
		Me.lblLatitude.Name = "lblLatitude"
		Me.lblLatitude.Size = New System.Drawing.Size(87, 18)
		Me.lblLatitude.TabIndex = 0
		Me.lblLatitude.Text = "Latitude:"
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.SatelliteViewer1)
		Me.TabPage2.Controls.Add(Me.chkShowCompass)
		Me.TabPage2.Controls.Add(Me.chkShowPRCNumbers)
		Me.TabPage2.Controls.Add(Me.chkEnableRotation)
		Me.TabPage2.Controls.Add(Me.SatelliteList)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Size = New System.Drawing.Size(388, 535)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Satellites"
		'
		'SatelliteViewer1
		'
		Me.SatelliteViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SatelliteViewer1.BackColor = System.Drawing.SystemColors.Control
		Me.SatelliteViewer1.CompassFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SatelliteViewer1.Location = New System.Drawing.Point(9, 228)
		Me.SatelliteViewer1.Name = "SatelliteViewer1"
		Me.SatelliteViewer1.PRCFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SatelliteViewer1.Receiver = Nothing
		Me.SatelliteViewer1.RotationMode = StormSource.GPS.Controls.RotationMode.RotateControlToBearing
		Me.SatelliteViewer1.Size = New System.Drawing.Size(372, 303)
		Me.SatelliteViewer1.TabIndex = 5
		'
		'chkShowCompass
		'
		Me.chkShowCompass.Checked = True
		Me.chkShowCompass.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkShowCompass.Location = New System.Drawing.Point(279, 204)
		Me.chkShowCompass.Name = "chkShowCompass"
		Me.chkShowCompass.Size = New System.Drawing.Size(102, 18)
		Me.chkShowCompass.TabIndex = 4
		Me.chkShowCompass.Text = "Show Compass"
		'
		'chkShowPRCNumbers
		'
		Me.chkShowPRCNumbers.Checked = True
		Me.chkShowPRCNumbers.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkShowPRCNumbers.Location = New System.Drawing.Point(144, 204)
		Me.chkShowPRCNumbers.Name = "chkShowPRCNumbers"
		Me.chkShowPRCNumbers.Size = New System.Drawing.Size(129, 18)
		Me.chkShowPRCNumbers.TabIndex = 3
		Me.chkShowPRCNumbers.Text = "Show PRC Numbers"
		'
		'chkEnableRotation
		'
		Me.chkEnableRotation.Location = New System.Drawing.Point(9, 204)
		Me.chkEnableRotation.Name = "chkEnableRotation"
		Me.chkEnableRotation.Size = New System.Drawing.Size(129, 18)
		Me.chkEnableRotation.TabIndex = 2
		Me.chkEnableRotation.Text = "Flicker-free demo"
		'
		'SatelliteList
		'
		Me.SatelliteList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SatelliteList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SatelliteID, Me.SatelliteElevation, Me.SatelliteAzimuth, Me.SatelliteSignalStrength})
		Me.SatelliteList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
		Me.SatelliteList.Location = New System.Drawing.Point(6, 6)
		Me.SatelliteList.Name = "SatelliteList"
		Me.SatelliteList.Size = New System.Drawing.Size(375, 192)
		Me.SatelliteList.TabIndex = 0
		Me.SatelliteList.View = System.Windows.Forms.View.Details
		'
		'SatelliteID
		'
		Me.SatelliteID.Text = "PRC"
		Me.SatelliteID.Width = 77
		'
		'SatelliteElevation
		'
		Me.SatelliteElevation.Text = "Elevation"
		Me.SatelliteElevation.Width = 80
		'
		'SatelliteAzimuth
		'
		Me.SatelliteAzimuth.Text = "Azimuth"
		Me.SatelliteAzimuth.Width = 81
		'
		'SatelliteSignalStrength
		'
		Me.SatelliteSignalStrength.Text = "Signal Strength"
		Me.SatelliteSignalStrength.Width = 116
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.lblRecognizedSentences)
		Me.TabPage3.Controls.Add(Me.lblUnrecognizedSentences)
		Me.TabPage3.Controls.Add(Me.UnrecognizedSentences)
		Me.TabPage3.Controls.Add(Me.Sentences)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(388, 535)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Raw Data"
		'
		'lblRecognizedSentences
		'
		Me.lblRecognizedSentences.AllowDrop = True
		Me.lblRecognizedSentences.Location = New System.Drawing.Point(6, 6)
		Me.lblRecognizedSentences.Name = "lblRecognizedSentences"
		Me.lblRecognizedSentences.Size = New System.Drawing.Size(129, 15)
		Me.lblRecognizedSentences.TabIndex = 8
		Me.lblRecognizedSentences.Text = "All Recognized Sentences:"
		'
		'lblUnrecognizedSentences
		'
		Me.lblUnrecognizedSentences.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblUnrecognizedSentences.AutoSize = True
		Me.lblUnrecognizedSentences.Location = New System.Drawing.Point(6, 333)
		Me.lblUnrecognizedSentences.Name = "lblUnrecognizedSentences"
		Me.lblUnrecognizedSentences.Size = New System.Drawing.Size(134, 16)
		Me.lblUnrecognizedSentences.TabIndex = 7
		Me.lblUnrecognizedSentences.Text = "Unrecognized Sentences:"
		'
		'UnrecognizedSentences
		'
		Me.UnrecognizedSentences.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.UnrecognizedSentences.IntegralHeight = False
		Me.UnrecognizedSentences.Location = New System.Drawing.Point(6, 354)
		Me.UnrecognizedSentences.Name = "UnrecognizedSentences"
		Me.UnrecognizedSentences.Size = New System.Drawing.Size(375, 174)
		Me.UnrecognizedSentences.TabIndex = 6
		'
		'Sentences
		'
		Me.Sentences.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Sentences.IntegralHeight = False
		Me.Sentences.Location = New System.Drawing.Point(6, 24)
		Me.Sentences.Name = "Sentences"
		Me.Sentences.ScrollAlwaysVisible = True
		Me.Sentences.Size = New System.Drawing.Size(375, 303)
		Me.Sentences.TabIndex = 4
		'
		'COMPort
		'
		Me.COMPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.COMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.COMPort.Items.AddRange(New Object() {"Automatic", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8"})
		Me.COMPort.Location = New System.Drawing.Point(414, 12)
		Me.COMPort.Name = "COMPort"
		Me.COMPort.Size = New System.Drawing.Size(75, 21)
		Me.COMPort.Sorted = True
		Me.COMPort.TabIndex = 5
		'
		'LocalTimeTimer
		'
		Me.LocalTimeTimer.Enabled = True
		Me.LocalTimeTimer.Interval = 1000
		Me.LocalTimeTimer.SynchronizingObject = Me
		'
		'Form1
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(502, 599)
		Me.Controls.Add(Me.COMPort)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.StatusBar)
		Me.Controls.Add(Me.StopButton)
		Me.Controls.Add(Me.StartButton)
		Me.MinimumSize = New System.Drawing.Size(100, 100)
		Me.Name = "Form1"
		Me.Text = "GPS.NET Complete Demonstration"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		CType(Me.LocalTimeTimer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region

	' Create a new GPS receiver and enable events
	Private WithEvents GPS As New Receiver()

	Private Sub GPS_Acquiring(ByVal sender As Object, ByVal e As System.EventArgs) Handles GPS.Acquiring
		SetStatus("A device was found.  Please wait while satellite information is gathered...")
	End Sub

#Region " Demonstration of Motion-Related GPS Events "
	Private Sub GPS_AltitudeChanged(ByVal sender As Object, ByVal e As DistanceEventArgs) Handles GPS.AltitudeChanged
		SetStatus("Altitude has changed.")
		' Update the label with the new altitude
		Me.Altitude.Text = e.Distance.ToString
	End Sub

	Private Sub GPS_BearingChanged(ByVal sender As Object, ByVal e As AzimuthEventArgs) Handles GPS.BearingChanged
		SetStatus("Bearing has changed.")
		' Update the label with the new bearing 
		Me.Bearing.Text = e.Azimuth.ToString
		' Update the label with the new bearing as a cardinal direction
		Me.Direction.Text = e.Azimuth.ToCardinalDirection.ToString
	End Sub

	Private Sub GPS_SpeedChanged(ByVal sender As Object, ByVal e As SpeedEventArgs) Handles GPS.SpeedChanged
		SetStatus("Speed has changed.")
		' Update the label with the new speed, converted to statute MPH
		Me.Speed.Text = e.Speed.ToStatuteMilesPerHour.ToString
	End Sub

	Private Sub GPS_PositionChanged(ByVal sender As Object, ByVal e As PositionEventArgs) Handles GPS.PositionChanged
		SetStatus("Position has changed.")
		' Update the labels with the new position
		Me.Longitude.Text = e.Position.Longitude.ToSexagesimal
		Me.Latitude.Text = e.Position.Latitude.ToSexagesimal
	End Sub
#End Region

#Region " Demonstration of Precision-Related Events "
	' Handles three events: PositionDilutionOfPrecisionChanged, HorizontalDilutionOfPrecisionChanged, and VerticalDilutionOfPrecisionChanged
	Private Sub GPS_DilutionOfPrecisionChanged(ByVal sender As Object, ByVal e As DilutionOfPrecisionEventArgs) Handles GPS.PositionDilutionOfPrecisionChanged, GPS.HorizontalDilutionOfPrecisionChanged, GPS.VerticalDilutionOfPrecisionChanged
		'Which DOP value changed?
		Select Case e.DilutionOfPrecision.Type
			Case DilutionOfPrecisionType.Position
				' Position DOP
				SetStatus("Position dilution of precision has changed")
				PDOP.Text = e.DilutionOfPrecision.Value & " (" & e.DilutionOfPrecision.Rating.ToString & ")"
			Case DilutionOfPrecisionType.Horizontal
				' Horizontal DOP
				SetStatus("Horizontal dilution of precision has changed")
				HDOP.Text = e.DilutionOfPrecision.Value & " (" & e.DilutionOfPrecision.Rating.ToString & ")"
			Case DilutionOfPrecisionType.Vertical
				' Vertical DOP
				SetStatus("Vertical dilution of precision has changed")
				VDOP.Text = e.DilutionOfPrecision.Value & " (" & e.DilutionOfPrecision.Rating.ToString & ")"
		End Select
	End Sub

	Private Sub GPS_MagneticVariationChanged(ByVal sender As Object, ByVal e As DegreeEventArgs) Handles GPS.MagneticVariationChanged
		SetStatus("Magnetic variation has changed")
		MagneticVariation.Text = e.Degree.ToDecimalDegrees
	End Sub
#End Region

	Private Sub GPS_ErrorOccurred(ByVal sender As Object, ByVal e As ErrorEventArgs) Handles GPS.ErrorOccurred
		Debug.WriteLine(e.GPSException.Message)
	End Sub

#Region " Demonstration of Fix-Related Events "
	Private Sub GPS_FixLost(ByVal sender As Object, ByVal e As System.EventArgs) Handles GPS.FixLost
		SetStatus("Satellite fix has been lost")
		FixObtained.Text = "No Fix Available"
	End Sub

	Private Sub GPS_FixMethodChanged(ByVal sender As Object, ByVal e As FixMethodEventArgs) Handles GPS.FixMethodChanged
		SetStatus("Satellite fix method has changed")
		FixMethod.Text = e.FixMethod.ToString
	End Sub

	Private Sub GPS_FixModeChanged(ByVal sender As Object, ByVal e As FixModeEventArgs) Handles GPS.FixModeChanged
		FixMode.Text = e.FixMode.ToString
	End Sub

	Private Sub GPS_FixObtained(ByVal sender As Object, ByVal e As System.EventArgs) Handles GPS.FixObtained
		SetStatus("Satellite fix has been obtained!")
		FixObtained.Text = "Fix Obtained"
	End Sub

	Private Sub GPS_FixQualityChanged(ByVal sender As Object, ByVal e As FixQualityEventArgs) Handles GPS.FixQualityChanged
		SetStatus("Satellite fix quality has changed")
		FixQuality.Text = e.FixQuality.ToString
	End Sub

#End Region

#Region " Demonstration of Satellite-Related GPS Events "
	Private Sub GPS_SatelliteAzimuthChanged(ByVal sender As Object, ByVal e As SatelliteEventArgs) Handles GPS.SatelliteAzimuthChanged
		' Update the list view associated with the specified satellite with the new azimuth
		SatelliteList.Items(e.Satellite.Index).SubItems(2).Text = e.Satellite.Azimuth.ToString
	End Sub

	Private Sub GPS_SatelliteElevationChanged1(ByVal sender As Object, ByVal e As SatelliteEventArgs) Handles GPS.SatelliteElevationChanged
		' Update the list view associated with the specified satellite with the new elevation
		SatelliteList.Items(e.Satellite.Index).SubItems(1).Text = e.Satellite.Elevation & "°"
	End Sub

	Private Sub GPS_SatelliteFixLost(ByVal sender As Object, ByVal e As SatelliteEventArgs) Handles GPS.SatelliteFixLost
		SatelliteList.Items(e.Satellite.Index).BackColor = Color.FromArgb(60, 255, 0, 0)
	End Sub

	Private Sub GPS_SatelliteFixObtained(ByVal sender As Object, ByVal e As SatelliteEventArgs) Handles GPS.SatelliteFixObtained
		SatelliteList.Items(e.Satellite.Index).BackColor = Color.FromArgb(60, 0, 255, 0)
	End Sub

	Private Sub GPS_SatellitePRCChanged(ByVal sender As Object, ByVal e As SatelliteEventArgs) Handles GPS.SatellitePRCChanged
		SatelliteList.Items(e.Satellite.Index).Text = e.Satellite.PRC
	End Sub

	Private Sub GPS_SatelliteSignalToNoiseRatioChanged(ByVal sender As Object, ByVal e As SatelliteEventArgs) Handles GPS.SatelliteSignalToNoiseRatioChanged
		SatelliteList.Items(e.Satellite.Index).SubItems(3).Text = e.Satellite.SignalToNoiseRatio.ToString & " (" & e.Satellite.SignalToNoiseRatio.Rating.ToString & ")"
	End Sub

	' Handles three events: SatelliteActiveCountChanged, SatelliteFixCountChanged, SatelliteTrackedCountChanged
	Private Sub GPS_SatelliteCountChanged(ByVal sender As Object, ByVal e As SatelliteCountEventArgs) Handles GPS.SatelliteActiveCountChanged, GPS.SatelliteFixedCountChanged, GPS.SatelliteTrackedCountChanged
		Select Case e.CountType
			Case SatelliteCountType.ActiveCount
				ActiveSatellites.Text = e.Count
			Case SatelliteCountType.FixedCount
				FixedSatellites.Text = e.Count
			Case SatelliteCountType.TrackedCount
				TrackedSatellites.Text = e.Count
		End Select
	End Sub
#End Region

#Region " Demonstration of Raw Sentence Processing "
	' Handles two events: SentenceReceived and UnrecognizedSentenceReceived
	Private Sub GPS_SentenceReceived(ByVal sender As Object, ByVal e As SentenceEventArgs) Handles GPS.SentenceReceived, GPS.UnrecognizedSentenceReceived
		' What kind of sentence is it?
		Select Case e.SentenceType
			Case SentenceType.Recognized
				' Add the sentence to the list of all sentences
				Sentences.Items.Add(e.Sentence)
				' Make sure the last item in the list is visible
				Sentences.SelectedIndex = Sentences.Items.Count - 1
			Case SentenceType.Unrecognized
				' Add the sentence to the list of all unrecognized sentences
				UnrecognizedSentences.Items.Add(e.Sentence)
				' Make sure the last item in the list is visible
				UnrecognizedSentences.SelectedIndex = UnrecognizedSentences.Items.Count - 1
				' Write it out to the console
				Debug.WriteLine("WARNING: Unrecognized/proprietary sentence received:" & e.Sentence)
		End Select
	End Sub

	Private Sub GPS_UTCDateTimeChanged(ByVal sender As Object, ByVal e As DateTimeEventArgs) Handles GPS.UTCDateTimeChanged
		SetStatus("Date/time has changed.")
		' Update the label with the new time (in UTC)
		UTCTime.Text = e.DateTime.ToString

		'*** NOTE: GPS sends time in UTC.  To show the GPS time converted to your local time, uncomment the following line
		'*** UTCTime.Text = NewDateTime.ToLocalTime.ToString
	End Sub
#End Region

#Region " Demonstration of Viewer Rotation "

	' Used to demonstrate the viewer's ability to rotate
	Private RotateThread As System.Threading.Thread

	Private Sub UpdateRotation()
		Do While True
			' Increase the rotation angle by half a degree
			SatelliteViewer1.Bearing += 0.5
			' Sleep for 50ms
			RotateThread.Sleep(25)
		Loop
	End Sub

	Private Sub chkEnableRotation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnableRotation.CheckedChanged
		If chkEnableRotation.Checked Then
			' Enable the rotation
			RotateThread = New System.Threading.Thread(New System.Threading.ThreadStart(AddressOf UpdateRotation))
			RotateThread.Name = "Demo of Rotating Satellite Viewer"
			RotateThread.IsBackground = True
			RotateThread.Start()
		Else
			' Disable the rotation
			If Not RotateThread Is Nothing Then
				RotateThread.Abort()
				RotateThread = Nothing
			End If
			' Reset the rotation to zero
			SatelliteViewer1.Bearing = 0
		End If
	End Sub

#End Region

#Region " Demonstration of Viewer Customization "

	Private Sub chkShowPRCNumbers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPRCNumbers.CheckedChanged
		SatelliteViewer1.IsSatellitePRCVisible = chkShowPRCNumbers.Checked
	End Sub

	Private Sub chkShowCompass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCompass.CheckedChanged
		SatelliteViewer1.IsCompassVisible = chkShowCompass.Checked
	End Sub
#End Region

#Region " Miscellaneous Form Events "

	Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		' Bind our instance of the GPS to the SatelliteViewer control
		SatelliteViewer1.Receiver = GPS
		' Default the COM port drop-down to COM4
		COMPort.SelectedIndex = 3
	End Sub

	Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
		' Disable the rotation demonstration
		If Not RotateThread Is Nothing Then
			RotateThread.Abort()
			RotateThread = Nothing
		End If
		' Unbind the GPS from the satellite viewer
		SatelliteViewer1.Receiver = Nothing
		' We're finished with the GPS completely.  Shut it down
		GPS.Stop()
		GPS = Nothing
	End Sub

	' Updates the status bar with the specified text
	Private Sub SetStatus(ByVal Message As String)
		StatusBar.Text = Message
	End Sub

	Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
		' Make sure we have a valid COM port
		If COMPort.Text = "" Then
			MsgBox("Please select the COM port connected to your GPS device, then click Start.", MsgBoxStyle.Information Or MsgBoxStyle.OKOnly)
			Exit Sub
		End If
		' Set the COM port to the numeric portion of the selected item in to combo box
		GPS.COMPort = COMPort.Text.Substring(3)
		' NOTE: It's important to add error checking around the Start() method and Enabled property
		Try
			' Start receiving messages
			GPS.Start()
			' Enable the Stop button, disable the Start button
			StartButton.Enabled = False
			StopButton.Enabled = True
		Catch ex As GPSException
			' Notify of the error
			MsgBox(ex.Message, MsgBoxStyle.Exclamation Or MsgBoxStyle.OKOnly)
		End Try
	End Sub

	Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
		GPS.Stop()
		StartButton.Enabled = True
		StopButton.Enabled = False
	End Sub

	' Update the local time to show the comparison between local time and the time obtained from the GPS receiver
	Private Sub LocalTimeTimer_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles LocalTimeTimer.Elapsed
		LocalTime.Text = Now.ToString
	End Sub
#End Region

End Class
