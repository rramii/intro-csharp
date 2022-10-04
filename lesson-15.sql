select sum(Freight) as "sum", round(SUM(Freight)/count(Freight),2) as "avg sum", avg(Freight) as "avg func"
from Orders


select OrderID, Freight
from Orders
where Freight > 500


--1
select CategoryName, Description
from Categories
order by CategoryName


--2
select ContactName, CompanyName, ContactTitle, Phone
from Customers
order by Phone


--3
select top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight
from Orders
order by Freight desc


--4
select City, CompanyName, ContactName
from Customers
where City like 'a%' or City like 'b%'


--5
select CompanyName, ContactName, Phone
from Customers
where Fax is null


--6
select LastName, FirstName, City
from Employees
where city != 'Seattle'


--7
select CustomerID, sum(Freight)
from Orders
group by CustomerID
having sum(Freight) > 200


--8
select ContactName
from Customers
where CustomerID in (
				select Freight + (select UnitPrice 
								from [Order Details]) 
				from Orders)


--1b
select *
from Orders

--2b
select OrderID, cost = (select UnitPrice
						from [Order Details])
from Orders
order by cost
--3b
select Customer = (select CustomerID 
					from Customers 
					where city = 'México D.F.'), 
		CustomerID, sum(Freight)
from Orders
where Customer = CustomerID
order by CustomerID
--4b



--5b



--6b



--7b