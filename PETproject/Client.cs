 class Client
    {
    private string _name;
    private string _cpf;
    private float _toPay;

    public void setName(string Name)
    {
        if (Name!=null && Name.Length>1)
        {
            _name = Name;
        }
    }
    public string getName() {
        return _name;
    }
    public void setCpf(string Cpf) {
        if (Cpf != null && Cpf.Length > 1)
        {
            _cpf = Cpf;
        }
    }
    public string getCpf() {
        return _cpf;
    }
    public void setToPay(float ToPay) {
        
        _toPay = ToPay; 
    }
    public float getToPay() {
        return _toPay;
    }
}


