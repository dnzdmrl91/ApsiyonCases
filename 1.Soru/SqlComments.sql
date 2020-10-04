
<--SORU 2
<-- Fiyatý 10 dan büyük olan ürünlerin gönderim tarihi nedir ?

SELECT orderDate from Orders o INNER JOIN OrderProduct c on o.orderId = c.orderId WHERE price>10

<-- customer1 isimli müþterinin ürünlerinin gönderim tarihi nedir ? 

SELECT orderDate from Orders o INNER JOIN Customers c on o.customerId = c.customerId WHERE customerName='customer1'

<--staff1 isimli çalýþanýn çalýþtýðý maðaza hangisidir ?

SELECT storeName from Stores s INNER JOIN Staffs c  on s.staffId = c.staffId WHERE staffName='staff1'

<-- Kategorisi mcat olan ürünlerin listesi 

SELECT productName from Products p INNER JOIN Categories c on p.catId = c.catId WHERE catName='mcat'

<-- SORU 3
<-- Fiyatý 25 olarak satýlan ürünün satýþ yapan kiþinin ismi nedir ?

SELECT staffName from Staffs WHERE staffId = 
(SELECT staffId from Stores WHERE storeId = 
(SELECT storeId from Orders WHERE orderId =
(SELECT orderId from Orders WHERE orderId = 
(SELECT orderId from OrderProduct WHERE price = 25))))


<-- product1 isimli ürünün müþterisi kimdir ? 

SELECT customerName from CUSTOMERS WHERE customerID=
(SELECT customerId from Orders WHERE orderId =
(SELECT orderId from Orders  WHERE orderId =
(SELECT orderId from OrderProduct WHERE productId =
(SELECT productId from Products WHERE productName='product1'))))



<-- brand3 markalý ürünün satýþ tarihi nedir ?

SELECT orderDate FROM Orders WHERE orderId=
(SELECT orderId from OrderProduct WHERE orderId =
(SELECT orderId from OrderProduct WHERE productId =
(SELECT productId from Products WHERE brandId =
(SELECT brandId from Brands WHERE brandName = 'brand3'))))


<-- mcat markalý ürünün storeId si kaçtýr ? 


SELECT storeId FROM Orders WHERE orderId=
(SELECT orderId from OrderProduct WHERE orderId =
(SELECT orderId from OrderProduct WHERE productId =
(SELECT productId from Products WHERE catId =
(SELECT catId from Categories WHERE catName = 'mcat'))))