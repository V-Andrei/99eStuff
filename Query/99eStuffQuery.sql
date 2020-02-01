CREATE DATABASE ninetyNineEStuff;

CREATE TABLE DetailedProducts
(
	IDDetailed int not null primary key,
	Material varchar(50),
	ProductWeight int not null,
	Size varchar(200),
	Stock int not null,
	BigPicture image,
	Detail1 varchar(200),
	Detail2 varchar(200),
	Detail3 varchar(200),
	Detail4 varchar(200),
	Detail5 varchar(200),
	[Description] text
)

CREATE TABLE Products
(
	ID int not null primary key,
	IDDetailed int not null foreign key references DetailedProducts(IDDetailed),
	NameProduct varchar(50) not null,
	Category varchar(20) not null,
	CurentPrice money not null,
	OldPrice money not null,
	SmallPicture image
)

insert into dbo.DetailedProducts
	([IDDetailed],[Material],[ProductWeight],[Size],[Stock],[BigPicture],[Detail1],[Detail2],[Detail3],[Detail4],[Detail5],[Description])
	values
	(
	1,
	'Cotton, Polyester',
	29,
	'W 350 x H 126 x D 2',
	9,
	(SELECT * FROM OPENROWSET(BULK N'D:\Wantsome\TheProject\99eStuff\ProductImg\BigImages\1.jpg', SINGLE_BLOB) as Img1),
	'Unisex money belt',
	'Conceals valuables under clothing',
	'Soft, comfy & easy to wear',
	'Protects passports, money & credit cards',
	'Single secure zipped compartment',
	'This ultra lightweight money belt is so comfortable you won''t even know you''re wearing it. Made from silky smooth yet strong fabrics, it is ideal for storing passports, cash and other valuables. Designed to be worn underneath clothing, the waistband is adjustable for a snug fit while the main compartment is zipped for maximum security.'
	);
insert into dbo.DetailedProducts
	([IDDetailed],[Material],[ProductWeight],[Size],[Stock],[BigPicture],[Detail1],[Detail2],[Detail3],[Detail4],[Detail5],[Description])
	values
	(
	2,
	'Polyester',
	127,
	'W 335 x H 120 x D 3',
	2,
	(SELECT * FROM OPENROWSET(BULK N'D:\Wantsome\TheProject\99eStuff\ProductImg\BigImages\2.jpg', SINGLE_BLOB) as Img2),
	'Travel document holder',
	'Carry passports, tickets & credit cards',
	'11 Well-proportioned compartments',
	'Zip-around design for total security',
	'Safe & convenient',
	'Providing a safe and convenient way to carry all of your holiday documents in one place, this travel wallet will organise even the most chaotic traveller. Ideal for storing passports, tickets and credit cards, 11 well-proportioned compartments offer quick and easy access to all your travel essentials for a smoother journey.'
	);
insert into dbo.DetailedProducts
	([IDDetailed],[Material],[ProductWeight],[Size],[Stock],[BigPicture],[Detail1],[Detail2],[Detail3],[Detail4],[Detail5],[Description])
	values
	(
	3,
	'Polyester, Spandex',
	24,
	'W 335 x H 120 x D 3',
	4,
	(SELECT * FROM OPENROWSET(BULK N'D:\Wantsome\TheProject\99eStuff\ProductImg\BigImages\3.jpg', SINGLE_BLOB) as Img3),
	'Money belt inspired by lingerie design',
	'Made from breathable, skin-soft fabrics',
	'Ultra comfy & easy to wear',
	'Conceals valuables under clothing',
	'Fully adjustable, one size fits all',
	'Inspired by the soft and supple nature of lingerie, this feminine money belt is made from breathable, skin-soft fabrics. Beautifully stretchy and oh so comfy, its good looks don''t detract from its core function; to protect your valuables. A single zipped compartment and internal pocket discretely conceals belongings under clothing for peace of mind when out and about.'
	);
insert into dbo.DetailedProducts
	([IDDetailed],[Material],[ProductWeight],[Size],[Stock],[BigPicture],[Detail1],[Detail2],[Detail3],[Detail4],[Detail5],[Description])
	values
	(
	4,
	'Leather',
	46,
	'W 103 x H 140 x D 10',
	14,
	(SELECT * FROM OPENROWSET(BULK N'D:\Wantsome\TheProject\99eStuff\ProductImg\BigImages\4.jpg', SINGLE_BLOB) as Img4),
	'Ultra smart passport holder',
	'Fits most passports worldwide',
	'Safeguards against data theft & digital crime',
	'Handcrafted in soft nappa leather',
	'Protects passport from wear & tear',
	'Handcrafted in soft nappa leather, this ultra sleek passport cover not only looks smart, it protects your passport from wear and tear. Designed to block illegal scans of RFID chips embedded in modern-day passports, it helps prevent identity theft by stopping sensitive personal data from being stolen. Slimline and stylish, this travel must-have fits most passports worldwide.'
	);
insert into dbo.DetailedProducts
	([IDDetailed],[Material],[ProductWeight],[Size],[Stock],[BigPicture],[Detail1],[Detail2],[Detail3],[Detail4],[Detail5],[Description])
	values
	(
	5,
	'Nylon, Polyester',
	37,
	'W 140 x H 185 x D 3',
	6,
	(SELECT * FROM OPENROWSET(BULK N'D:\Wantsome\TheProject\99eStuff\ProductImg\BigImages\5.jpg', SINGLE_BLOB) as Img5),
	'Soft & comfy neck pouch',
	'Protects passports, money & other valuables',
	'Designed to be worn under clothing',
	'Unisex styling',
	'Includes 2 secure zipped compartments',
	'Slimline enough to wear under clothing and discreet enough to protect your belongings, this passport pouch is an essential travel companion. Its soft, comfy exterior makes it suitable for wearing on long journeys, while the 2 zipped front pockets protect passports, money and other valuables. A handy mesh compartment on the reverse ensures a place for everything.'
	);
insert into dbo.DetailedProducts
	([IDDetailed],[Material],[ProductWeight],[Size],[Stock],[BigPicture],[Detail1],[Detail2],[Detail3],[Detail4],[Description])
	values
	(
	6,
	'Polyester',
	217,
	'W 135 x H 265 x D 22',
	15,
	(SELECT * FROM OPENROWSET(BULK N'D:\Wantsome\TheProject\99eStuff\ProductImg\BigImages\6.jpg', SINGLE_BLOB) as Img6),
	'RFID travel organiser',
	'Carry passports, cards & money together',
	'Blocks illegal RFID scanning equipment',
	'Protects against identity theft & digital crime',
	'An essential piece of kit for any well-organised traveller, this travel document holder offers the added security of RFID protection. Designed to block illegal scans of RFID chips embedded in modern-day passports and credits cards, it stops highly sensitive personal data from being stolen. 18 well-organised compartments offer ample storage for everything from travel documents and tickets to passports and credit cards.'
	);
insert into dbo.DetailedProducts
	([IDDetailed],[Material],[ProductWeight],[Size],[Stock],[BigPicture],[Detail1],[Detail2],[Detail3],[Detail4],[Detail5],[Description])
	values
	(
	7,
	'Polyester',
	36,
	'W 77 x H 97 x D 14',
	6,
	(SELECT * FROM OPENROWSET(BULK N'D:\Wantsome\TheProject\99eStuff\ProductImg\BigImages\7.jpg', SINGLE_BLOB) as Img7),
	'Large capacity wallet with RFID protection',
	'Blocks RFID scanning equipment',
	'Protects against identity theft and digital crime',
	'Secure magnetic closure',
	'Dual function card view window allows you to effortlessly slide out a card',
	'Stop digital pickpockets in their tracks with this stylish tri-fold RFID wallet. Ensuring that you don’t become a victim of digital fraud, this large capacity wallet integrates an RFID shield to safeguard all of your sensitive, secure data embedded in bank card chips. A large pocket is perfect for notes and a boarding pass, while the multiple card slots have a convenient dual function view window which not only allows you to instantly identify your card but also slide it effortlessly out of the slot. A secure and simple-to-use magnetic closure offers extra peace of mind.'
	);