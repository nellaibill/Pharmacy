Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection("Data Source=SERVER\SQLEXPRESS;Initial Catalog=PharmacyDB;User ID=sa")
    'Public con As New SqlConnection("Data Source=SAM-PC\SQLExpress;Initial Catalog=PharmacyDB;Integrated Security=True")
    Public con1 As New SqlConnection("Data Source=SERVER\SQLEXPRESS;initial catalog=LaskhmiHospital;User Id=sa")
    'Public con1 As New SqlConnection("Data Source=SAM-PC\SQLExpress;Initial Catalog=LakshmiHospitalDB;Integrated Security=True")
    Public UserRights, UserName As String
    Public crysBillNo, crysBillYear As String
    Public PrinterName As String
End Module
