import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderDetailsFComponent } from './order-details-f.component';

describe('OrderDetailsFComponent', () => {
  let component: OrderDetailsFComponent;
  let fixture: ComponentFixture<OrderDetailsFComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrderDetailsFComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrderDetailsFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
