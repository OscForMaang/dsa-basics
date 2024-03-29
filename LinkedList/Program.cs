// c# Linked List



long bsonTimetick = 1706782455833;

DateTime dateTime = ConvertBsonDateTimeToDateTime(bsonTimetick);

Console.WriteLine(dateTime);

static DateTime ConvertBsonDateTimeToDateTime(long bsonDateTime)
{
    // Unix epoch time
    DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    // Convert BSON DateTime to TimeSpan
    TimeSpan timeSpan = TimeSpan.FromMilliseconds(bsonDateTime);

    // Add the TimeSpan to Unix epoch to get the DateTime value
    DateTime dateTime = unixEpoch.Add(timeSpan);

    return dateTime;
}