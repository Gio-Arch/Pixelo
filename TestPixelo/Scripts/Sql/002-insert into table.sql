USE [test]
GO

--begin tran

INSERT INTO [dbo].[Bets]
           ([MatchDescription]
           ,[RateOne]
           ,[RateDraw]
           ,[RateTwo])
     VALUES
           ('Bologna - Milan',4.20,1.85,1.10),
           ('Inter - Torino',1.20,2.85,3.10),
           ('Ascoli - Brescia',4.20,1.85,1.10),
           ('Palermo - Roma',4.20,1.85,1.10),
           ('Lazio - Salernitana',4.20,1.85,1.10),
           ('Sampdoria - Juventus',4.20,1.85,1.10),
           ('Pordenone - Lecce',4.20,1.85,1.10),
           ('Pisa - Reggiana',4.20,1.85,1.10),
           ('Arsenal - Manchester',4.20,1.85,1.10),
           ('Eibar - Sibiglia',4.20,1.85,1.10),
           ('Napoli - Udinese',4.20,1.85,1.10),
           ('Verona - Parma',4.20,1.85,1.10),
           ('Cagliari - Bologna',4.20,1.85,1.10)
           
GO

--rollback