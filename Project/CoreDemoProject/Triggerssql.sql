
CREATE TRIGGER AddBlogInRaytingTable
ON Blogs
AFTER INSERT
AS
BEGIN
	DECLARE @ID INT
	SELECT @ID =  BlogID FROM inserted
	INSERT INTO BlogRaytings (BlogID, BlogTotalScore, BlogTotalRaytingCount) VALUES (@ID, 0, 0)
END


ALTER TRIGGER AddScoreInComment
ON Comments
AFTER INSERT
AS
BEGIN	
	DECLARE @ID INT
	DECLARE @Score INT
	DECLARE @RaytingCount INT
	SELECT @ID = BlogID, @Score=BlogScore FROM inserted
	
	UPDATE BlogRaytings SET BlogTotalScore = BlogTotalScore + @Score, BlogTotalRaytingCount = BlogTotalRaytingCount + 1 WHERE BlogID = @ID
END