using Valid_Parens;

Solution sol = new Solution();
string[] s = { "((({{}])))", "(((())))", "(([{}]))", "(({{[[]]})))", "{[]}" };
//false
//true
//true
//false
//true 
foreach(string p in s)
{
    Console.WriteLine(sol.IsValid(p));
}
