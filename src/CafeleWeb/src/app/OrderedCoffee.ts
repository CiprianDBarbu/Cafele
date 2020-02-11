import { Coffee } from './coffee';
import { Syroup } from './syroup';

export class OrderedCoffee {
    coffee:Coffee;
    syroup:Syroup;
    nrCoffees: number;
    /**
     *
     */
    constructor() {
       this.syroup = null;
       this.coffee = null;   
           
    }

    public TotalPrice(): number 
    {
        let priceCoffee=0;
        if(this.coffee != null){
            priceCoffee=this.coffee.price;
        }
        if(this.syroup != null)
        {
            priceCoffee += this.syroup.price;
        }
        return this.nrCoffees * priceCoffee;
    }
}
