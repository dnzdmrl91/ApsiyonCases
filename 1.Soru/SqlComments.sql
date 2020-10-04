
<--SORU 2
<-- Fiyat� 10 dan b�y�k olan �r�nlerin g�nderim tarihi nedir ?

SELECT orderDate from Orders o INNER JOIN OrderProduct c on o.orderId = c.orderId WHERE price>10

<-- customer1 isimli m��terinin �r�nlerinin g�nderim tarihi nedir ? 

SELECT orderDate from Orders o INNER JOIN Customers c on o.customerId = c.customerId WHERE customerName='customer1'

<--staff1 isimli �al��an�n �al��t��� ma�aza hangisidir ?

SELECT storeName from Stores s INNER JOIN Staffs c  on s.staffId = c.staffId WHERE staffName='staff1'

<-- Kategorisi mcat olan �r�nlerin listesi 

SELECT productName from Products p INNER JOIN Categories c on p.catId = c.catId WHERE catName='mcat'

<-- SORU 3
<-- Fiyat� 25 olarak sat�lan �r�n�n sat�� yapan ki�inin ismi nedir ?

SELECT staffName from Staffs WHERE staffId = 
(SELECT staffId from Stores WHERE storeId = 
(SELECT storeId from Orders WHERE orderId =
(SELECT orderId from Orders WHERE orderId = 
(SELECT orderId from OrderProduct WHERE price = 25))))


<-- product1 isimli �r�n�n m��terisi kimdir ? 

SELECT customerName from CUSTOMERS WHERE customerID=
(SELECT customerId from Orders WHERE orderId =
(SELECT orderId from Orders  WHERE orderId =
(SELECT orderId from OrderProduct WHERE productId =
(SELECT productId from Products WHERE productName='product1'))))



<-- brand3 markal� �r�n�n sat�� tarihi nedir ?

SELECT orderDate FROM Orders WHERE orderId=
(SELECT orderId from OrderProduct WHERE orderId =
(SELECT orderId from OrderProduct WHERE productId =
(SELECT productId from Products WHERE brandId =
(SELECT brandId from Brands WHERE brandName = 'brand3'))))


<-- mcat markal� �r�n�n storeId si ka�t�r ? 


SELECT storeId FROM Orders WHERE orderId=
(SELECT orderId from OrderProduct WHERE orderId =
(SELECT orderId from OrderProduct WHERE productId =
(SELECT productId from Products WHERE catId =
(SELECT catId from Categories WHERE catName = 'mcat'))))