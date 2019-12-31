import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderedCoffeeComponent } from './ordered-coffee.component';

describe('OrderedCoffeeComponent', () => {
  let component: OrderedCoffeeComponent;
  let fixture: ComponentFixture<OrderedCoffeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrderedCoffeeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrderedCoffeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
