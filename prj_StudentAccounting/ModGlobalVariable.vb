﻿Imports MySql.Data.MySqlClient

Module ModGlobalVariable

    Public conDB As New MySqlConnection
    Public command As New MySqlCommand
    Public str_connection As String
    Public server_name As String
    Public DB_name As String
    Public DB_user As String
    Public DB_pass As String
    Public port As String
    Public studentPhotoPath As String
    Public sqlDBAdapter As New MySqlDataAdapter
    Public dataTable As New DataTable
    Public row As Integer
    Public currentDate As String

    'User details'
    Public userID As String
    Public studentName As String
    Public studentProgram As String
    Public studentYearLevel As String

    'Admin details'
    Public adminUserID As String

End Module