import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SyroupsComponent } from './syroups.component';

describe('SyroupsComponent', () => {
  let component: SyroupsComponent;
  let fixture: ComponentFixture<SyroupsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SyroupsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SyroupsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
