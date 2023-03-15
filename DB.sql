CREATE TABLE Opportunity (
  opportunity_id INT NOT NULL,
  title VARCHAR(100),
  image VARBINARY(max),
  details TEXT,
  PRIMARY KEY (opportunity_id) 
);

CREATE TABLE ContactUS(
  email VARCHAR (50),
  name VARCHAR (50) ,
  address VARCHAR(100),
  message TEXT,
  opportunity_id INT,
  PRIMARY KEY (email),
  FOREIGN KEY (opportunity_id) REFERENCES Opportunity(opportunity_id)
);
CREATE TABLE users (
  id INTEGER PRIMARY KEY IDENTITY,
  username TEXT NOT NULL,
  password TEXT NOT NULL
);
