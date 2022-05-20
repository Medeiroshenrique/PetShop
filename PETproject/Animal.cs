class Animal
{
    private string _species;
    private string _name;
    private string _identification;
    private string _gender;
    private string _desiredService;
    private int _yearsOld;
    

    public void setSpecies(string Species)
    {
        if (Species != null && Species.Length > 1)
            {
            _species = Species;
        }
    }
    public string getSpecies()
    {
        return _species;
    }
    public void setName(string Name)
    {
        if (Name != null && Name.Length > 1)
        {
            _name = Name;
        }

    }
    public string getName() {
        return _name;   
    }
    public void setIdentification(string Identification) {
        if (Identification != null && Identification.Length > 1)
        {
            _identification = Identification;
        }
    }
    public string getIdentification() {
        return _identification;
    }
    public void setGender(string Gender)
    {
        if (Gender != null && Gender.Length > 1) { 
            _gender = Gender;
        }
    }
    public string getGender() {
        return _gender;
    }
    public void setDesiredService(string DesiredService) {
        _desiredService = DesiredService;
    }
    public string getDesiredService() {
        return _desiredService;
    }
    public void setYearsOld(int YearsOld) {
        if (YearsOld != null && YearsOld > 0)
        {
            _yearsOld = YearsOld;
        }
    }
    public int getYearsOld() {
        return _yearsOld;
    }
}



