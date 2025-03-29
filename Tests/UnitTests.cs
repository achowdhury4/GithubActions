namespace GithubActionsLab;

[TestClass]
public class MathTests
{
	// ADD
	[TestMethod]
	public void Add_Valid_Chowdhury()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Chowdhury()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Chowdhury()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

	// SUBTRACT
	[TestMethod]
	public void Subtract_Valid_Chowdhury()
	{
		Assert.AreEqual(-1, Program.Subtract("1", "2"));
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(-2, Program.Subtract("5", "7"));
	}

	[TestMethod]
	public void Subtract_Invalid_Chowdhury()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
	}

	[TestMethod]
	public void Subtract_Null_Chowdhury()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
	}

	// MULTIPLY
	[TestMethod]
	public void Multiply_Valid_Chowdhury()
	{
		Assert.AreEqual(2, Program.Multiply("1", "2"));
		Assert.AreEqual(6, Program.Multiply("3", "2"));
	}

	[TestMethod]
	public void Multiply_Invalid_Chowdhury()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
	}

	[TestMethod]
	public void Multiply_Null_Chowdhury()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
	}

	// DIVIDE
	[TestMethod]
	public void Divide_Valid_Chowdhury()
	{
		Assert.AreEqual(2, Program.Divide("4", "2"));
		Assert.AreEqual(1.5, Program.Divide("3", "2"));
	}


	[TestMethod]
	public void Divide_Invalid_Chowdhury()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
	}

	// POWER
	[TestMethod]
	public void Power_Valid_Chowdhury()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
		Assert.AreEqual(1, Program.Power("10", "0"));
	}

	[TestMethod]
	public void Power_Invalid_Chowdhury()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("x", "y"));
	}

	[TestMethod]
	public void Power_Null_Chowdhury()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
	}
}
