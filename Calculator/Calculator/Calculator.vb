Public Class Calculator

    Dim value1 As Double
    Dim value2 As Double
    Dim boxIsEmpty As Boolean
    Dim allowZero As Boolean
    Dim operation As String
    Dim asWeGo As String
    Dim selectedButton As Button

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Send calculator to middle of the screen...not able to find property to do this.
        Me.CenterToScreen()
        resultsBox.Text = "0"
    End Sub

    Private Sub zeroButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zeroButton.Click
        If boxIsEmpty = True Then
            If resultsBox.Text.Length > 0 Or allowZero = True Then
                resultsBox.Text &= "0"
                asWeGo &= "0"
            End If
        End If
        display()
    End Sub

    'This will handle the click events of number buttons 1-9.
    Private Sub add1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1Button.Click, add2Button.Click, add3Button.Click, add4Button.Click, add5Button.Click, add6Button.Click, add7Button.Click, add8Button.Click, add9Button.Click
        Dim whichButton As Integer

        selectedButton = CType(sender, Button)
        whichButton = selectedButton.Name.Substring(3, 1)

        If boxIsEmpty = True Then
            resultsBox.Text &= whichButton
        Else
            resultsBox.Text = whichButton
            boxIsEmpty = True
        End If
        asWeGo &= whichButton
        display()
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        operation = String.Empty
        boxIsEmpty = False
        allowZero = False
        display()
        resultsBox.Text = "0"
        asWeGo = String.Empty
        display()
    End Sub


    Private Sub decimalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decimalButton.Click
        If Not (resultsBox.Text.Contains(".")) Then
            resultsBox.Text &= "."
            asWeGo &= "."
        ElseIf resultsBox.Text.Contains("+") Or resultsBox.Text.Contains("-") Or resultsBox.Text.Contains("*") Or resultsBox.Text.Contains("/") Then
            resultsBox.Text &= "."
            asWeGo &= "."
        End If
        boxIsEmpty = True
        display()
    End Sub

    Private Sub plusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plusButton.Click, minusButton.Click, multiplyButton.Click, divideButton.Click
        selectedButton = CType(sender, Button)

        If resultsBox.Text.Length > 0 Then
            If operation = String.Empty Then
                value1 = Convert.ToDouble(resultsBox.Text)
                resultsBox.Text = String.Empty
            Else
                doArithmetic()
            End If

            Select Case (selectedButton.Name)
                Case "plusButton"
                    operation = "+"
                Case "minusButton"
                    operation = "-"
                Case "multiplyButton"
                    operation = "*"
                Case "divideButton"
                    operation = "/"
            End Select

            allowZero = True
            asWeGo &= operation
            display()
        End If
    End Sub

    'This method is what makes things like 1+1+1+1 work. By storing the value before the operator in value1 and the value after the operator in value2
    'and then operating on those two values.
    Private Sub doArithmetic()
        value2 = Convert.ToDouble(resultsBox.Text)

        Select Case (operation) 'Counterpart to javas switch statement.
            Case "+"
                value1 = value1 + value2
            Case "-"
                value1 = value1 - value2
            Case "*"
                value1 = value1 * value2
            Case "/"
                value1 = value1 / value2
            Case "sin"
                value1 = Math.Sin(value1)
            Case "cos"
                value1 = Math.Cos(value1)
            Case "tan"
                value1 = Math.Tan(value1)
        End Select
        resultsBox.Text = value1.ToString
        boxIsEmpty = False
        allowZero = False
        'asWeGo = value1.ToString
        'display()

    End Sub

    Private Sub equalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equalButton.Click
        If resultsBox.Text.Length > 0 And value1 <> 0 Then
            doArithmetic()
            operation = String.Empty
            asWeGo = String.Empty
            display()
        End If
    End Sub

    Private Sub plusNegativeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plusNegativeButton.Click
        If resultsBox.Text.Length > 0 Then
            resultsBox.Text = -resultsBox.Text
        End If
        asWeGo &= "*(-1)"
        display()
    End Sub

    Private Sub display()
        StringBox.Text = asWeGo
    End Sub

    'Extra Stuff:

    Private Sub sinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinButton.Click, cosButton.Click, tanButton.Click
        selectedButton = CType(sender, Button)
        operation = selectedButton.Name.Substring(0, 3)
        doArithmetic()
    End Sub

    'I think this works..
    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        If resultsBox.Text.Length > 0 Then
            resultsBox.Text = resultsBox.Text.Remove(resultsBox.Text.Length - 1, 1)
        End If
        If StringBox.Text.Length > 0 Then
            asWeGo = asWeGo.Remove(asWeGo.Length - 1, 1)
            display()
        End If

    End Sub
End Class