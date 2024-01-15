SELECT * FROM `customers`;
SELECT * FROM `offices`;
SELECT * FROM `orderdetails`;
SELECT * FROM `payments`;
SELECT * FROM `productlines`;
SELECT * FROM `products`;

SELECT pd.productName, pd.quantityInStock, pdl.productLine, pdl.textDescription 
FROM products pd  
LEFT JOIN productlines pdl
	ON pd.productLine = pdl.productLine;
	
SELECT c.customerName, c.phone, e.firstName, e.officeCode, o.addressLine1, o.country 
FROM customers c 
	LEFT JOIN employees e 
		ON c.salesRepEmployeeNumber = e.employeeNumber
	LEFT JOIN offices o 
		ON e.officeCode = o.officeCode;

SELECT c.customerName, c.phone, o.orderNumber, o.orderDate, pd.productName, pd.productDescription 
FROM customers c 
	LEFT JOIN orders o
		ON c.customerNumber = o.customerNumber
    LEFT JOIN orderdetails od
        ON o.orderNumber = od.orderNumber
    LEFT JOIN products pd
        ON od.productCode = pd.productCode;

SELECT o.orderNumber, o.orderDate, py.paymentDate, py.checkNumber, py.amount,  od.productCode, p.productName, p.productDescription
FROM orders o 
	LEFT JOIN orderdetails od
        ON o.orderNumber = od.orderNumber
    INNER JOIN payments py 
        ON o.customerNumber = py.customerNumber
    LEFT JOIN products p 
        ON od.productCode = p.productCode;        
    
