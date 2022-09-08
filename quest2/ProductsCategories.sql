
SELECT categories.categoryname, products.productname FROM  categories, products where (products.types = categories.categoryname) or (categories.productname = products.productname);