
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub uiAdd_Click(sender As Object, e As RoutedEventArgs)
        App._lista.Add(New JedenCounter With {.nazwa = Date.Now.ToString("yyyy-MM-dd HH:mm")})
    End Sub

    Private Sub uiMinus_Click(sender As Object, e As RoutedEventArgs)
        Dim oFE As FrameworkElement = sender
        If oFE Is Nothing Then Return
        Dim oItem As JedenCounter = oFE.DataContext

        oItem.counter -= 1
        RefreshLista()
    End Sub

    Private Sub uiPlus_Click(sender As Object, e As RoutedEventArgs)
        Dim oFE As FrameworkElement = sender
        If oFE Is Nothing Then Return
        Dim oItem As JedenCounter = oFE.DataContext

        oItem.counter += 1
        RefreshLista()
    End Sub

    Private Sub uiZero_Click(sender As Object, e As RoutedEventArgs)
        Dim oFE As FrameworkElement = sender
        If oFE Is Nothing Then Return
        Dim oItem As JedenCounter = oFE.DataContext

        oItem.counter = 0
        RefreshLista()
    End Sub

    Private Sub uiDel_Click(sender As Object, e As RoutedEventArgs)
        Dim oFE As FrameworkElement = sender
        If oFE Is Nothing Then Return
        Dim oItem As JedenCounter = oFE.DataContext

        App._lista.Remove(oItem)
    End Sub

    Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
        RefreshLista()
    End Sub

    Private Sub RefreshLista()
        uiListItems.ItemsSource = Nothing
        uiListItems.ItemsSource = App._lista
    End Sub
End Class
