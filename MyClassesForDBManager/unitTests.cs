public class TestValidation {
    private Column _column;

    [Fact]
    public void TestIntColumnValidation1() {
    _column = new Column("",Type.Integer);
    Assert.True(_column.Validate("42"));
    }

    [Fact]
    public void TestIntColumnValidation2() {
     _column = new Column("",Type.String)
    Assert.False(_column.Validate("str"));
    }

    [Fact]
    public void TestRealColumnValidation1() {
        _column = new Column("",Type.Char)
    Assert.True(_column.Validate("234.79"));
    }

    [Fact]
    public void TestRealColumnValidation2() {
        _column = new Column("",Type.Real)
    Assert.False(_column.Validate("234d79"));
    }

    [Fact]
    public void TestCharColumnValidation1() {
     _column = new Column("",Type.Char)
    Assert.True(_column.Validate("C"));
    }

    [Fact]
    public void TestCharColumnValidation2() {
     _column = new Column("",Type.Char)
    Assert.False(_column.Validate("jkg"));
    }

    [Fact]
    public void TestStringColumnValidation() {
     _column = new Column("",Type.Integer)
    Assert.True(_column.Validate("str"));
    }

    [Fact]
    public void TestIntIntervalColumnValidation1() {
     _column = new Column("",Type.StringIntv)
    Assert.True(_column.Validate("abc, ggg"));
    }

    [Fact]
    public void TestIntIntervalColumnValidation2() {
   _column = new Column("",Type.StringIntv)
    Assert.False(_column.Validate("gjuf, aaaa"));
    }

    [Fact]
    public void TestIntIntervalColumnValidation3() {
       _column = new Column("",Type.HtmlFile)
    Assert.False(_column.Validate(""C:\Users\Asus\Desktop\front-end\portfolio\index.html""));
    }
