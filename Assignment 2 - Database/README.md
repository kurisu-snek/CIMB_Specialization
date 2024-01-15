# Offices Database

### In folder Assignment 2, there are 2 files available

- **_bank_db.sql_** - Database, table creation and data insertion
- **_bank_query.sql_** - Select query to show table contents and relations

## Preview

### SQL Query for :

1. Display all customers data
   <br>

   ```sql
   SELECT * FROM `customers`
   ```

   | customerNumber | customerName    | contactLastName | contactFirstName | phone        | addressLine1    | addressLine2 | city        | state      | postalCode | country | salesRepEmployeeNumber | creditLimit |
   | -------------- | --------------- | --------------- | ---------------- | ------------ | --------------- | ------------ | ----------- | ---------- | ---------- | ------- | ---------------------- | ----------- |
   | 1              | Ken Block       | Block           | Ken              | 082457382392 | Atlantic Ave    | Long Beach   | Los Angeles | California | 90806      | USA     | 1                      | 60000.00    |
   | 2              | Travis Pastrana | Pastrana        | Travis           | 083465738475 | Long Beach Blvd | Compton      | Los Angeles | California | 90221      | USA     | 2                      | 370000.00   |

2. Display all offices data
   <br>

   ```sql
   SELECT * FROM `offices`
   ```

   | officeCode | city        | phone       | addressLine1 | addressLine2 | state      | country | postalCode | territory |
   | ---------- | ----------- | ----------- | ------------ | ------------ | ---------- | ------- | ---------- | --------- |
   | A1         | Los Angeles | 1300774859  | Red Ave      | San Diego    | Calofornia | USA     | 49302      | CAL       |
   | A2         | Los Angeles | 13004563567 | Pacific Ave  | Long Beach   | California | USA     | 90806      | CAL       |

3. Display all order details data
   <br>

   ```sql
   SELECT * FROM `orderdetails`
   ```

   | orderLineNumber | orderNumber | productCode | quantityOrdered | priceEach |
   | --------------- | ----------- | ----------- | --------------- | --------- |
   | 1               | 3           | 1004        | 1               | 50000.00  |
   | 2               | 4           | 1003        | 1               | 32000.00  |

4. Display all payments data
   <br>

   ```sql
   SELECT * FROM `payments`
   ```

   | customerNumber | checkNumber     | paymentDate | amount   |
   | -------------- | --------------- | ----------- | -------- |
   | 1              | 300029485843930 | 2023-12-18  | 32000.00 |
   | 2              | 300029393940394 | 2024-01-08  | 55000.00 |

5. Display all product lines data
   <br>

   ```sql
   SELECT * FROM `productlines`
   ```

   | productLine  | textDescription                   | htmlDescription | image        |
   | ------------ | --------------------------------- | --------------- | ------------ |
   | Honda type R | Honda Racing Heritage Performance | typer.html      | typer.jpg    |
   | Toyota GR    | Toyota Gazoo Racing               | toyotagr.html   | toyotagr.jpg |

6. Display all products data
   <br>

   ```sql
   SELECT * FROM `products`
   ```

   | productCode | productName    | productLine  | productScale | productVendor | productDescription                     | quantityInStock | buyPrice | MSRP     |
   | ----------- | -------------- | ------------ | ------------ | ------------- | -------------------------------------- | --------------- | -------- | -------- |
   | 1001        | Civic type R   | Honda type R | 1            | Honda         | Honda Civic type R FK8                 | 4               | 40000.00 | 37000.00 |
   | 1002        | Integra type R | Honda type R | 1            | Honda         | Honda Integra type R (DC2)             | 1               | 30000.00 | 25000.00 |
   | 1003        | GR86           | Toyota GR    | 1            | Toyota        | Toyota GR86                            | 5               | 32000.00 | 30000.00 |
   | 1004        | GR Supra RZ    | Toyota GR    | 3            | Toyota        | Toyota GR Supra RZ Performance Package | 5               | 55000.00 | 50000.00 |

## Relational Database

1. Display data from products and productlines table
   <br>

   ```sql
   SELECT pd.productName, pd.quantityInStock, pdl.productLine, pdl.textDescription
   FROM products pd
   LEFT JOIN productlines pdl
   	ON pd.productLine = pdl.productLine
   ```

   | productName    | quantityInStock | productLine  | textDescription                   |
   | -------------- | --------------- | ------------ | --------------------------------- |
   | Civic type r   | 4               | Honda type R | Honda Racing Heritage Performance |
   | Integra type r | 1               | Honda type R | Honda Racing Heritage Performance |
   | GR86           | 5               | Toyota GR    | Toyota Gazoo Racing               |
   | GR Supra RZ    | 3               | Toyota GR    | Toyota Gazoo Racing               |

2. Display data from customer, employees, dan office tables
   <br>

   ```sql
   SELECT c.customerName, c.phone, e.firstName, e.officeCode, o.addressLine1, o.country
   FROM customers c
   	LEFT JOIN employees e
   		ON c.salesRepEmployeeNumber = e.employeeNumber
   	LEFT JOIN offices o
   		ON e.officeCode = o.officeCode
   ```

   | customerName    | phone         | firstName | officeCode | addressLine1 | country |
   | --------------- | ------------- | --------- | ---------- | ------------ | ------- |
   | Ken Block       | 0824573823920 | Mat       | A1         | Red Ave      | USA     |
   | Travis Pastrana | 083465738475  | Mat       | A1         | Red Ave      | USA     |

3. Display data from customers, orders, order details and products table
   <br>
   ```sql
   SELECT c.customerName, c.phone, o.orderNumber, o.orderDate, pd.productName, pd.productDescription
   FROM customers c
      LEFT JOIN orders o
         ON c.customerNumber = o.customerNumber
      LEFT JOIN orderdetails od
         ON o.orderNumber = od.orderNumber
      LEFT JOIN products pd
         ON od.productCode = pd.productCode
   ```

   | customerName    | phone         | orderNumber | orderDate  | productName | productDescription                     |
   | --------------- | ------------- | ----------- | ---------- | ----------- | -------------------------------------- |
   | Ken Block       | 0824573823920 | 3           | 2024-01-01 | GR Supra RZ | Toyota GR Supra RZ Performance Package |
   | Travis Pastrana | 083465738475  | 4           | 2023-12-18 | GR86        | Toyota GR86                            |

4. Display data from order, order details, payments and products table
   <br>

   ```sql
   SELECT o.orderNumber, o.orderDate, py.paymentDate, py.checkNumber, py.amount,  od.productCode, p.productName, p.productDescription
   FROM orders o
      LEFT JOIN orderdetails od
         ON o.orderNumber = od.orderNumber
      INNER JOIN payments py
         ON o.customerNumber = py.customerNumber
      LEFT JOIN products p
         ON od.productCode = p.productCode;
   ```

   | orderNumber | orderDate  | paymentDate | checkNumber     | amount   | productCode | productName | productDescription                     |
   | ----------- | ---------- | ----------- | --------------- | -------- | ----------- | ----------- | -------------------------------------- |
   | 4           | 2023-12-18 | 2023-12-19  | 300029485843930 | 32000.00 | 1003        | GR86        | Toyota GR86                            |
   | 3           | 2024-01-01 | 2024-01-08  | 300029393940394 | 55000.00 | 1004        | GR Supra RZ | Toyota GR Supra RZ Performance Package |
