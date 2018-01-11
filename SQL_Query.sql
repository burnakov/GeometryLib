SELECT DISTINCT Name 
FROM Customers
	JOIN Purchase
	ON Customers.CustomerId = Purchase.CustomerId AND Purchase.ProductName = 'Milk'
WHERE Purchase.CustomerId 
	NOT IN 	(
			SELECT CustomerId
			FROM Purchase
			WHERE ProductName = 'Sour cream' 
				AND buyers.PurchaiseDatetime > DATEADD (mm, -1, GETDATE())
			)
