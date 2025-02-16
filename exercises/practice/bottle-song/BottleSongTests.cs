using Xunit;

public class BottleSongTests
{
    [Fact]
    public void Verse_single_verse_first_generic_verse()
    {
        var expected =
            "Ten green bottles hanging on the wall,\n" +
            "Ten green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be nine green bottles hanging on the wall.";
        Assert.Equal(expected, BottleSong.Recite(10, 1));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Verse_single_verse_last_generic_verse()
    {
        var expected =
            "Three green bottles hanging on the wall,\n" +
            "Three green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be two green bottles hanging on the wall.";
        Assert.Equal(expected, BottleSong.Recite(3, 1));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Verse_single_verse_verse_with_two_bottles()
    {
        var expected =
            "Two green bottles hanging on the wall,\n" +
            "Two green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be one green bottle hanging on the wall.";
        Assert.Equal(expected, BottleSong.Recite(2, 1));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Verse_single_verse_verse_with_one_bottle()
    {
        var expected =
            "One green bottle hanging on the wall,\n" +
            "One green bottle hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be no green bottles hanging on the wall.";
        Assert.Equal(expected, BottleSong.Recite(1, 1));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Lyrics_multiple_verses_first_two_verses()
    {
        var expected =
            "Ten green bottles hanging on the wall,\n" +
            "Ten green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be nine green bottles hanging on the wall.\n" +
            "\n" +
            "Nine green bottles hanging on the wall,\n" +
            "Nine green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be eight green bottles hanging on the wall.";
        Assert.Equal(expected, BottleSong.Recite(10, 2));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Lyrics_multiple_verses_last_three_verses()
    {
        var expected =
            "Three green bottles hanging on the wall,\n" +
            "Three green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be two green bottles hanging on the wall.\n" +
            "\n" +
            "Two green bottles hanging on the wall,\n" +
            "Two green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be one green bottle hanging on the wall.\n" +
            "\n" +
            "One green bottle hanging on the wall,\n" +
            "One green bottle hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be no green bottles hanging on the wall.";
        Assert.Equal(expected, BottleSong.Recite(3, 3));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Lyrics_multiple_verses_all_verses()
    {
        var expected =
            "Ten green bottles hanging on the wall,\n" +
            "Ten green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be nine green bottles hanging on the wall.\n" +
            "\n" +
            "Nine green bottles hanging on the wall,\n" +
            "Nine green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be eight green bottles hanging on the wall.\n" +
            "\n" +
            "Eight green bottles hanging on the wall,\n" +
            "Eight green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be seven green bottles hanging on the wall.\n" +
            "\n" +
            "Seven green bottles hanging on the wall,\n" +
            "Seven green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be six green bottles hanging on the wall.\n" +
            "\n" +
            "Six green bottles hanging on the wall,\n" +
            "Six green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be five green bottles hanging on the wall.\n" +
            "\n" +
            "Five green bottles hanging on the wall,\n" +
            "Five green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be four green bottles hanging on the wall.\n" +
            "\n" +
            "Four green bottles hanging on the wall,\n" +
            "Four green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be three green bottles hanging on the wall.\n" +
            "\n" +
            "Three green bottles hanging on the wall,\n" +
            "Three green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be two green bottles hanging on the wall.\n" +
            "\n" +
            "Two green bottles hanging on the wall,\n" +
            "Two green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be one green bottle hanging on the wall.\n" +
            "\n" +
            "One green bottle hanging on the wall,\n" +
            "One green bottle hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be no green bottles hanging on the wall.";
        Assert.Equal(expected, BottleSong.Recite(10, 10));
    }
}
