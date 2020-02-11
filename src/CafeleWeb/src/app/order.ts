import { OrderedCoffee } from './OrderedCoffee';

export class  Order {
    constructor() {
        this.coffees=[];
        //this.TotalPrice=0;
    }
    coffees:OrderedCoffee[];
    public TotalPrice(): number{
        let total:number = 0;
        for(let i of this.coffees)
        {
            total += i.TotalPrice();
        }
        return total;
    }

    public TotalNumberCoffees():number{
    let TotNr = 0;
        for(let el of this.coffees)
        {
            TotNr += el.nrCoffees ;
        }

        return TotNr;
    }
}
