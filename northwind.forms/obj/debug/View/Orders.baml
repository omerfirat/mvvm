   M S B A M L   `   `   `  ����J  FNorthwind.Forms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Northwind.Forms.ViewModelNorthwind.Forms.ViewModel  5   	   !    Northwind.Forms.View.Orders   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6vm'clr-namespace:Northwind.Forms.ViewModel     5   	     � Title$  Orders��5   	   $��481.836��6   $	��867��6)    � DataContext 5   	   �� .   (Northwind.Forms.ViewModel.OrderViewModel   Instance �� Source# Z .��5      �  � ColumnDefinitions 5   
   �� 5	      $
��197* �6   �� 5
      $
��604* �6   .+�5   
   � $��0��6    5      �� 5      $	��85* �6#   �� 5      $
��112* �6#    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��0��6"   $��Customer ID��62   $��Center=�6J   �� 5       $��1��6   $��0��6"   $��Company Name��62   $��Center=�6J   �� 5!      $��2��6   $��0��6"   $��Contact Name��62   $��Center=�6J   �� 5"      $��3��6   $��0��6"   $��Contact Title��62   $��Center=�6J   �� 5#      $��4��6   $��0��6"   $��Address��62   $��Center=�6J   �� 5$      $��5��6   $��0��6"   $
��City��62   $��Center=�6J   �� 5%      $��6��6   $��0��6"   $��Region��62   $��Center=�6J   �� 5&      $��7��6   $��0��6"   $��Postal Code��62   $��Center=�6J   �� 5'      $��8��6   $��0��6"   $��Country��62   $��Center=�6J   �� 5(      $��9��6   $��0��6"   $��Phone��62   $��Center=�6J   �� 5)      $��10��6   $��0��6"   $	��Fax��62   $��Center=�6J   �� 5*      -   5        $��TextBoxCustId��5*   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��0��6{    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *SelectedOrder.Customer_ID+�� 5+      -   5        $��TextBoxCompanyName��5+   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��1��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *%#SelectedOrder.Customer.Company_Name+�� 5,      -   5        $��TextBoxContactName��5,   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��2��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *%#SelectedOrder.Customer.Contact_Name+�� 5-      -   5        $��TextBoxContactTitle��5-   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��3��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *&$SelectedOrder.Customer.Contact_Title+�� 5.      -   5        $��TextBoxAdress��5.   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��4��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� * SelectedOrder.Customer.Address+�� 5/      -   5        $��TextBoxCity��5/   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��5��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *SelectedOrder.Customer.City+�� 50      -   5        $��TextBoxRegion��50   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��6��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *SelectedOrder.Customer.Region+�� 51      -   5        $��TextBoxPostalCode��51   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��7��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *$"SelectedOrder.Customer.Postal_Code+�� 52      -	   5        $��TextBoxCountry��52   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��8��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� * SelectedOrder.Customer.Country+�� 53      -
   5        $��TextBoxPhone��53   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��9��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *SelectedOrder.Customer.Phone+�� 54      -   5        $��
TextBoxFax��54   &   $��1��6   $
��Left=�6A   $��23��6\   $��	10,12,0,0q�6h   $��10��6{   $
 Wrap=�6�   $	��Top=�6�   $��92��6�   ��6�   �� *SelectedOrder.Customer.Fax+55      � 56   
   $��1��6    57      �� 58      $
��294* �6    �� 59      $
��251* �6    �� 5:      $	��43* �6    .+�5=      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridOrders��5?      $��0��5=         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5>      $��10q�5@      	   AutoGenerateColumns	 .  ��5A      �� *Orders+
 �� SelectedItem
 5C      �� *SelectedOrder+   Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ Order Id��6)      Width$	 100 6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6P   �� *
Order_ID+  5F      $ Customer Id��6)   $	 100 6D    6P   �� *Customer_ID+  5G      $ Employee Id��6)   $	 100 6D    6P   �� *Employee_ID+  5H      $ 	Ship Name��6)   $	 100 6D    6P   �� *	Ship_Name+  5I      $ Ship Adress��6)   $	 100 6D    6P   �� *Ship_Address+  5J      $ 	Ship City��6)   $	 100 6D    6P   �� *	Ship_City+  5K      $ Ship Region��6)   $	 200 6D    6P   �� *Ship_Region+  5L      $ Ship Postal Code��6)   $	 200 6D    6P   �� *Ship_Postal_Code+  5M      $ Ship Country��6)   $	 200 6D    6P   �� *Ship_Country+  5N      $ Ship Via��6)   $	 200 6D    6P   �� *
Ship_Via+  5O      $ 
Order Date��6)   $	 200 6D    6P   �� *Shipped_Date+4  .System.Windows.Controls.DataGridTemplateColumn  5P      $ Required Date��6-   $	 200 6D      CellTemplate 5R      �� 5S      .R�5T   "   �� ��6,   �� *Required_Date+5U         CellEditingTemplate 5X      �� 5Y      .R�5Z   "   (  "System.Windows.Controls.DatePicker     SelectedDate 6-   �� *Required_Date+5[      5]        5_      $ 	Ürünler��6-   $	 200 6>    5`      �� 5a      .R�5b   "   ��  �� DisplayMemberPath$ Product_Name��5c   '    �� SelectedValuePath$ 
Product_ID��5d   '   ��5b   +   �� *DataContext.ProductList+ �� RelativeSource ��  �� AncestorType$ WindowL� �� SelectedValue 5e   '   �� *
Product_ID+ �� UpdateSourceTrigger$ PropertyChanged=�5f      5i        5j      $ Shipped Date��6)   $	 200 6D    6P   �� *Shipped_Date+  5k      $ Freight��6)   $	 200 6D    6P   �� *	Freight+5m        5o      -   5        $ DataGridOrderDetails��5s      $��1��5o      $ * 5p      	 .  $��10q�5t      ��5q      �� *SelectedDetails+ 5u        5v      $ Order Id��6)   $	 200 6e    6>   �� *
Order_ID+6e     5w      $ 
Product Id��6)   $	 200 6e    6>   �� *
Product_ID+6e     5x      $ 
Unit Price��6)   $	 200 6e    6>   �� *
Unit_Price+6e     5y      $ Quantity��6)   $	 200 6e    6>   �� *
Quantity+6e     5z      $ Discount��6)   $	 200 6e    6>   �� *
Discount+6e   5|      �� 5}      $��Sipariş Ekle��6   $
��Left=�6-   $��	10,10,0,0q�6H   $��2��6[   $	��Top=�6h   $��75��6�   $��22��6�   �� 5~      $��Sipariş Çıkar��6   $
��Left=�6-   $��	90,10,0,0q�6H   $��2��6[   $	��Top=�6h   $��75��6�   $��22��6�   5      5�      5�      