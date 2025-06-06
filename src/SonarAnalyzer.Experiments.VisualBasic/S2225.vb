﻿Imports System

Class Condition
    Shared Function [When]() As Boolean
        Return True
    End Function
End Class

Namespace Compliant
    Class OtherMethodReturnsNothingString
        Function Returns() As String
            Return Nothing
        End Function
    End Class

    Class ReturnsSomeString
        Public Overrides Function ToString() As String
            If Condition.[When]() Then
                Return "Hello, world!"
            End If

            Return "Hello, world!"
        End Function
    End Class

    Class ReturnsEmptyString
        Public Overrides Function ToString() As String
            If Condition.[When]() Then
                Return ""
            End If

            Return ""
        End Function
    End Class

    Class ReturnsStringEmpty
        Public Overrides Function ToString() As String
            If Condition.[When]() Then
                Return String.Empty
            End If

            Return String.Empty
        End Function
    End Class

    Class LambdaReturnsNothing
        Public Overrides Function ToString() As String
            Dim lambda As Func(Of String) =
                Function() As String
                    Return Nothing ' Noncompliant - FP
                End Function

            If True Then
                Return Nothing
            End If

            Return String.Empty
        End Function
    End Class

    Structure StructReturnsStringEmpty
        Public Overrides Function ToString() As String
            If Condition.[When]() Then
                Return String.Empty
            End If

            Return String.Empty
        End Function
    End Structure
End Namespace

Class Noncompliant
    Public Class ReturnsNothing
        Public Overrides Function ToString() As String
            If Condition.[When]() Then
                Return Nothing
            End If

            Return Nothing
        End Function
    End Class

    Public Class ReturnsNothingViaTenary
        Public Overrides Function ToString() As String
            Return If(Condition.[When](), Nothing, "")  ' Compliant - FN
        End Function
    End Class

    Public Overrides Function ToString() As String
        If Condition.[When]() Then
            Return Nothing ' Noncompliant
            '   ^^^^^^^^^^^^^^
        End If
        ' Noncompliant
        Return Nothing
    End Function
End Class

Structure StructReturnsNothing
    Public Overrides Function ToString() As String
        If Condition.[When]() Then
            Return Nothing ' Noncompliant
        End If

        Return Nothing ' Noncompliant
    End Function
End Structure
