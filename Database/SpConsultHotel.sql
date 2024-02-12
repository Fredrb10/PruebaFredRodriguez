USE [PruebaFredRodriguez]
GO

IF EXISTS (SELECT 1
      FROM sys.objects
      WHERE object_id = OBJECT_ID('SpConsultHotel')
            AND
            type IN ('P' , 'PC')
  )
  DROP PROCEDURE dbo.SpConsultHotel

GO

CREATE PROCEDURE SpConsultHotel (
                 @CityId INT ,
                 @Capacity INT ,
                 @AdmissionDate VARCHAR(10) ,
                 @DepartureDate VARCHAR(10)
)
AS
  BEGIN

    SELECT h.HotelId, h.Name as Hotel, h.Address, c.Name as City, h.Phone, r.RoomId, rt.Name AS Room, r.RoomNumber, r.Floor, r.BasePrice
    FROM Hotels h 
	INNER JOIN Rooms r 
	        ON r.IdHotel = h.HotelId 
    INNER JOIN RoomTypes rt 
	        ON rt.RoomTypeId = r.IdRoomType
    INNER JOIN Cities c 
	        ON c.CityId = h.CityId
    WHERE h.CityId = @CityId
      AND rt.Capacity = @Capacity
	  AND h.Enabled = 1
	  AND r.Enabled = 1
      AND NOT EXISTS (SELECT *
                        FROM Reservations re
                       WHERE re.HotelId = h.HotelId
					     AND re.RoomId = r.RoomId
                         AND re.AdmissionDate >= @AdmissionDate
                         AND re.DepartureDate < @DepartureDate)
  END