CREATE QUEUE [dbo].[UserEmailAlertQueue] 
WITH STATUS=ON, 
RETENTION=OFF,
POISON_MESSAGE_HANDLING (STATUS=OFF)
ON [PRIMARY]
