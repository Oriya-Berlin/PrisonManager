CREATE TABLE [dbo].[Table] (
    [Id]        INT          NOT NULL,
    [Fname]     VARCHAR (50) NOT NULL,
    [Lname]     VARCHAR (50) NOT NULL,
    [ID_num]    VARCHAR (50) NOT NULL,
    [gender]    VARCHAR (50) NOT NULL,
    [crime]     VARCHAR (50) NOT NULL,
    [penalty]   INT          NOT NULL,
    [date]      VARCHAR (50) NOT NULL,
    [front_img] IMAGE        NULL,
    [side_img]  IMAGE        NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Fname])
);

