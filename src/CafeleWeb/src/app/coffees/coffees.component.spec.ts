import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CoffeesComponent } from './coffees.component';

describe('CoffeesComponent', () => {
  let component: CoffeesComponent;
  let fixture: ComponentFixture<CoffeesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CoffeesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CoffeesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
