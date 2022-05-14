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
        _species = Species;
    }
    public string getSpecies()
    {
        return _species;
    }
    public void setName(string Name)
    {
        _name = Name;
    }
    public string getName() {
        return _name;   
    }
    public void setIdentification(string Identification) {
        _identification = Identification;
    }
    public string getIdentification() {
        return _identification;
    }
    public void setGender(string Gender) {
        _gender =Gender;   
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
        _yearsOld = YearsOld;
    }
    public int getYearsOld() {
        return _yearsOld;
    }
}



