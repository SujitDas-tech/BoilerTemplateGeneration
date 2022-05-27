create table TblFront(FrontID int NOT NULL IDENTITY(1,1) Primary key, FrontName varchar(200)) 
INSERT INTO TblBackEnd (BackName) values ("Flask"),("Django");
INSERT INTO TblFront (FrontName) values ("HTML-CSS"),("ASP.Net-Core");
INSERT INTO TblBoilerLookUp (BoilerID,TechName,TechPath) values ("1-1","HTML-CSS-Flask","https://firebasestorage.googleapis.com/v0/b/projectfiles-f17b4.appspot.com/o/html-css-flask.zip?alt=media&token=8c11a895-dd1b-498c-b18f-dd86816cf889"),("2-1","ASP.Net-Core-Flask","https://firebasestorage.googleapis.com/v0/b/projectfiles-f17b4.appspot.com/o/Asp.Net-Core-Flask.zip?alt=media&token=04a33572-300d-4c38-a4b4-3f7ed4fda66a");
INSERT INTO TblLoginDetails (Passwor,UserName) VALUES("demo123","demo@gmail.com");