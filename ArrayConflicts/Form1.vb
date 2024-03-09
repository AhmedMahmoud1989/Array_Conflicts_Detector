
Public Class Form1
    Private Function makeDateList(FromDate As DateTime, ToDate As DateTime) As List(Of DateTime)
        Dim tempFrom As New DateTime(FromDate.Year, FromDate.Month, FromDate.Day, 0, 0, 0, 0)
        Dim tempTo As New DateTime(ToDate.Year, ToDate.Month, ToDate.Day, 0, 0, 0, 0)

        Dim tmpDate As DateTime = tempFrom
        Dim lst As New List(Of DateTime)

        lst.Add(tmpDate)

        While tmpDate < tempTo
            tmpDate = tmpDate.AddDays(1)
            lst.Add(tmpDate)
        End While

        Return lst

    End Function
    Function DateIntersect(firstDateList As List(Of DateTime), secondDateList As List(Of DateTime)) As List(Of DateTime)
        Dim lstResulat As New List(Of DateTime)
        Dim lstENuma As IEnumerable(Of DateTime) = firstDateList.Intersect(secondDateList)
        lstResulat = lstENuma.ToList

        Return lstResulat
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lst As New List(Of DateTime)

        lst = DateIntersect(makeDateList(dtFrom.Value, dtTo.Value), makeDateList(dt1.Value, dt2.Value))

        ListBox1.DataSource = lst


    End Sub
End Class
