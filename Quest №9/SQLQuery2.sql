SELECT Product.Name as 'Продукт',Category.Name as 'Категория' FROM Product 
LEFT JOIN ProductCategory on Product.Id = ProductCategory.Product_Id
LEFT JOIN Category on Category.Id = ProductCategory.Category_Id