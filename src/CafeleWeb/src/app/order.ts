import { OrderedCoffee } from './OrderedCoffee';

export class  Order {
    constructor() {
        this.CoffeList=[];
        //this.TotalPrice=0;
    }
    CoffeList:OrderedCoffee[];
    public TotalPrice(): number{
        let total:number = 0;
        for(let i of this.CoffeList)
        {
            total += i.TotalPrice();
        }
        return total;
    }
}
