Select * from Review

Select * from Product



Insert Into Product (DatePublished,Title,ShortDescription,Brand)
Values (GETDATE(),'APV Gaulin Mono-Block','An integrated design of cylinders (3 or 5), pump valves, plunger lubrication and inlet/outlet in one block.','APV')

Insert Into Product (DatePublished,Title,ShortDescription,Brand)
Values (GETDATE(),'Gasketed Plate Heat Exchanger - Industrial','Gasketed Plate Heat Exchanger for Industrial Applications.','APV')

Insert Into Product (DatePublished,Title,ShortDescription,Brand)
Values (GETDATE(),'Mono-Block','pump valves','SPX')

Insert Into Product (DatePublished,Title,ShortDescription,Brand)
Values (GETDATE(),'Heat Exchanger - Industrial','Gasketed Plate','SPXFLOW')


Insert Into Review (Product_Id,Rating,Comment,[User])
Values (0,5,'This is a great.','John D.')

Insert Into Review (Product_Id,Rating,Comment,[User])
Values (1,4,'Had some issues with this product','Anonymous')

Insert Into Review (Product_Id,Rating,Comment,[User])
Values (1,3,'This product review cant exceed 256 characters. If I put more than that, my review will be truncated!','John D.')

Insert Into Review (Product_Id,Rating,Comment,[User])
Values (2,4,'Worst Product','Anonymous')

