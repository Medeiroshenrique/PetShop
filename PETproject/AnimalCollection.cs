class AnimalCollection
    {
    List<Animal> PetsCollection = new List<Animal>();
    public void toAdd(Animal p) {
        PetsCollection.Add(p);
    }
    public void toRemove(Animal p){
        PetsCollection.Remove(p);
    }
    public void searchFor(Animal p) { }
    }

