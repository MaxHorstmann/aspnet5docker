-- Table: locations

-- DROP TABLE locations;

CREATE TABLE locations
(
    id INT NOT NULL,
    name VARCHAR (100) NOT NULL
);


ALTER TABLE locations
  OWNER TO postgres;