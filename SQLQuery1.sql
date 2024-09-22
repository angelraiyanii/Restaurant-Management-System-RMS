create table users(
id int primary key identity(1,1),
username varchar(max),
password varchar(max),
Profile_image varchar(max),
role varchar(max),
status varchar(max),
date_reg date 
)


select *from users



insert into users (username,password,profile_image,role,status,date_reg)Values('admin','a121','','Admin','Active','2023-12-1'); 


    create table products(

    id int primary Key identity(1,1),
    p_id varchar(max) null,
    p_name varchar(max) null,
    p_type varchar(max) null, 
    p_stock int null,
    p_price float null,
    p_status varchar(max) null,
    p_image varchar(max) null,
    data_insert date null,
    data_update date null,
    data_delete date null,
)

select * from products

select *from products where data_delete IS NULL

1032, 532

239, 47