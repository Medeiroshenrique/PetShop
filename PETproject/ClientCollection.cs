using System.Collections.Generic;
using System.Linq;
class ClientCollection: IPetContract
{
    List<Client> CustomerCollection = new List<Client>();
    public void toAdd(Client c) {
        CustomerCollection.Add(c);
    }
    public void toRemove(Client c) {
        CustomerCollection.Remove(c);
    }
    public void searchFor(Client c) {
        }
    }

