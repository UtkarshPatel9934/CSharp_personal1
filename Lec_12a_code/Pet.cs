namespace Example1
{
	class Pet 
	{
		private string _name; // baking field 
                
		private string _bread;
	       public Pet()
	       {
		       _name = "";
		       _bread = "King Charles";

	       }

	       public string Name
	       {
		       get{
			       return _name;
		       }


		       set{
			       _name = value;
		       }
	       }

	       public string Bread{
		      
		      get{ return _bread;}
	       
	       }

	      
	}

}