CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

CREATE TABLE "Users" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "Email" text NOT NULL,
    "Contact" character varying(10) NOT NULL,
    "Address" text NOT NULL,
    "JoinDate" timestamp with time zone NOT NULL,
    "Role" integer NOT NULL,
    "Created" timestamp with time zone NOT NULL,
    "LastModified" timestamp with time zone NULL,
    CONSTRAINT "PK_Users" PRIMARY KEY ("Id")
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230425083856_Initial', '6.0.16');

COMMIT;

START TRANSACTION;

ALTER TABLE "Users" ADD "DamageCost" double precision NOT NULL DEFAULT 0.0;

ALTER TABLE "Users" ADD "IsEmailConfirmed" boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Users" ADD "LastRental" timestamp with time zone NOT NULL DEFAULT TIMESTAMPTZ '-infinity';

ALTER TABLE "Users" ADD "NumOfRentals" integer NOT NULL DEFAULT 0;

ALTER TABLE "Users" ADD "Password" text NOT NULL DEFAULT '';

ALTER TABLE "Users" ADD "TimesDamaged" integer NOT NULL DEFAULT 0;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230425165551_UserDB', '6.0.16');

COMMIT;

