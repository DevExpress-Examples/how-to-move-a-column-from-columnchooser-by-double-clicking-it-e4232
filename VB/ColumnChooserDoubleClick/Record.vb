Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace ColumnChooserDoubleClick
	Public Class Record

		Public Sub New(ByVal s1 As String, ByVal s2 As String, ByVal s3 As String, ByVal s4 As String, ByVal s5 As String)
			Field1 = s1
			Field2 = s2
			Field3 = s3
			Field4 = s4
			Field5 = s5
		End Sub

		Private privateField1 As String
		Public Property Field1() As String
			Get
				Return privateField1
			End Get
			Set(ByVal value As String)
				privateField1 = value
			End Set
		End Property
		Private privateField2 As String
		Public Property Field2() As String
			Get
				Return privateField2
			End Get
			Set(ByVal value As String)
				privateField2 = value
			End Set
		End Property
		Private privateField3 As String
		Public Property Field3() As String
			Get
				Return privateField3
			End Get
			Set(ByVal value As String)
				privateField3 = value
			End Set
		End Property
		Private privateField4 As String
		Public Property Field4() As String
			Get
				Return privateField4
			End Get
			Set(ByVal value As String)
				privateField4 = value
			End Set
		End Property
		Private privateField5 As String
		Public Property Field5() As String
			Get
				Return privateField5
			End Get
			Set(ByVal value As String)
				privateField5 = value
			End Set
		End Property
	End Class
End Namespace
