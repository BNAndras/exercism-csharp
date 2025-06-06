public class ForthTests
{
    [Fact]
    public void Parsing_and_numbers_numbers_just_get_pushed_onto_the_stack()
    {
        Assert.Equal("1 2 3 4 5", Forth.Evaluate(["1 2 3 4 5"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Parsing_and_numbers_pushes_negative_numbers_onto_the_stack()
    {
        Assert.Equal("-1 -2 -3 -4 -5", Forth.Evaluate(["-1 -2 -3 -4 -5"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Addition_can_add_two_numbers()
    {
        Assert.Equal("3", Forth.Evaluate(["1 2 +"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Addition_errors_if_there_is_nothing_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["+"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Addition_errors_if_there_is_only_one_value_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["1 +"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Addition_more_than_two_values_on_the_stack()
    {
        Assert.Equal("1 5", Forth.Evaluate(["1 2 3 +"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Subtraction_can_subtract_two_numbers()
    {
        Assert.Equal("-1", Forth.Evaluate(["3 4 -"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Subtraction_errors_if_there_is_nothing_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["-"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Subtraction_errors_if_there_is_only_one_value_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["1 -"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Subtraction_more_than_two_values_on_the_stack()
    {
        Assert.Equal("1 9", Forth.Evaluate(["1 12 3 -"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Multiplication_can_multiply_two_numbers()
    {
        Assert.Equal("8", Forth.Evaluate(["2 4 *"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Multiplication_errors_if_there_is_nothing_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["*"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Multiplication_errors_if_there_is_only_one_value_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["1 *"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Multiplication_more_than_two_values_on_the_stack()
    {
        Assert.Equal("1 6", Forth.Evaluate(["1 2 3 *"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Division_can_divide_two_numbers()
    {
        Assert.Equal("4", Forth.Evaluate(["12 3 /"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Division_performs_integer_division()
    {
        Assert.Equal("2", Forth.Evaluate(["8 3 /"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Division_errors_if_dividing_by_zero()
    {
        Assert.Throws<DivideByZeroException>(() => Forth.Evaluate(["4 0 /"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Division_errors_if_there_is_nothing_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["/"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Division_errors_if_there_is_only_one_value_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["1 /"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Division_more_than_two_values_on_the_stack()
    {
        Assert.Equal("1 4", Forth.Evaluate(["1 12 3 /"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Combined_arithmetic_addition_and_subtraction()
    {
        Assert.Equal("-1", Forth.Evaluate(["1 2 + 4 -"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Combined_arithmetic_multiplication_and_division()
    {
        Assert.Equal("2", Forth.Evaluate(["2 4 * 3 /"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Combined_arithmetic_multiplication_and_addition()
    {
        Assert.Equal("13", Forth.Evaluate(["1 3 4 * +"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Combined_arithmetic_addition_and_multiplication()
    {
        Assert.Equal("7", Forth.Evaluate(["1 3 4 + *"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Dup_copies_a_value_on_the_stack()
    {
        Assert.Equal("1 1", Forth.Evaluate(["1 dup"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Dup_copies_the_top_value_on_the_stack()
    {
        Assert.Equal("1 2 2", Forth.Evaluate(["1 2 dup"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Dup_errors_if_there_is_nothing_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["dup"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Drop_removes_the_top_value_on_the_stack_if_it_is_the_only_one()
    {
        Assert.Equal("", Forth.Evaluate(["1 drop"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Drop_removes_the_top_value_on_the_stack_if_it_is_not_the_only_one()
    {
        Assert.Equal("1", Forth.Evaluate(["1 2 drop"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Drop_errors_if_there_is_nothing_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["drop"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Swap_swaps_the_top_two_values_on_the_stack_if_they_are_the_only_ones()
    {
        Assert.Equal("2 1", Forth.Evaluate(["1 2 swap"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Swap_swaps_the_top_two_values_on_the_stack_if_they_are_not_the_only_ones()
    {
        Assert.Equal("1 3 2", Forth.Evaluate(["1 2 3 swap"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Swap_errors_if_there_is_nothing_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["swap"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Swap_errors_if_there_is_only_one_value_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["1 swap"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Over_copies_the_second_element_if_there_are_only_two()
    {
        Assert.Equal("1 2 1", Forth.Evaluate(["1 2 over"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Over_copies_the_second_element_if_there_are_more_than_two()
    {
        Assert.Equal("1 2 3 2", Forth.Evaluate(["1 2 3 over"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Over_errors_if_there_is_nothing_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["over"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Over_errors_if_there_is_only_one_value_on_the_stack()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["1 over"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_can_consist_of_built_in_words()
    {
        Assert.Equal("1 1 1", Forth.Evaluate([": dup-twice dup dup ;", "1 dup-twice"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_execute_in_the_right_order()
    {
        Assert.Equal("1 2 3", Forth.Evaluate([": countup 1 2 3 ;", "countup"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_can_override_other_user_defined_words()
    {
        Assert.Equal("1 1 1", Forth.Evaluate([": foo dup ;", ": foo dup dup ;", "1 foo"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_can_override_built_in_words()
    {
        Assert.Equal("1 1", Forth.Evaluate([": swap dup ;", "1 swap"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_can_override_built_in_operators()
    {
        Assert.Equal("12", Forth.Evaluate([": + * ;", "3 4 +"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_can_use_different_words_with_the_same_name()
    {
        Assert.Equal("5 6", Forth.Evaluate([": foo 5 ;", ": bar foo ;", ": foo 6 ;", "bar foo"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_can_define_word_that_uses_word_with_the_same_name()
    {
        Assert.Equal("11", Forth.Evaluate([": foo 10 ;", ": foo foo 1 + ;", "foo"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_cannot_redefine_non_negative_numbers()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate([": 1 2 ;"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_cannot_redefine_negative_numbers()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate([": -1 2 ;"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_errors_if_executing_a_non_existent_word()
    {
        Assert.Throws<InvalidOperationException>(() => Forth.Evaluate(["foo"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void User_defined_words_only_defines_locally()
    {
        Assert.Equal("0", Forth.Evaluate([": + - ;", "1 1 +"]));
        Assert.Equal("2", Forth.Evaluate(["1 1 +"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Case_insensitivity_dup_is_case_insensitive()
    {
        Assert.Equal("1 1 1 1", Forth.Evaluate(["1 DUP Dup dup"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Case_insensitivity_drop_is_case_insensitive()
    {
        Assert.Equal("1", Forth.Evaluate(["1 2 3 4 DROP Drop drop"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Case_insensitivity_swap_is_case_insensitive()
    {
        Assert.Equal("2 3 4 1", Forth.Evaluate(["1 2 SWAP 3 Swap 4 swap"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Case_insensitivity_over_is_case_insensitive()
    {
        Assert.Equal("1 2 1 2 1", Forth.Evaluate(["1 2 OVER Over over"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Case_insensitivity_user_defined_words_are_case_insensitive()
    {
        Assert.Equal("1 1 1 1", Forth.Evaluate([": foo dup ;", "1 FOO Foo foo"]));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Case_insensitivity_definitions_are_case_insensitive()
    {
        Assert.Equal("1 1 1 1", Forth.Evaluate([": SWAP DUP Dup dup ;", "1 swap"]));
    }
}
