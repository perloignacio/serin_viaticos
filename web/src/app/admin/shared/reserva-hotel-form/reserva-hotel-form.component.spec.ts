import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReservaHotelFormComponent } from './reserva-hotel-form.component';

describe('ReservaHotelFormComponent', () => {
  let component: ReservaHotelFormComponent;
  let fixture: ComponentFixture<ReservaHotelFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReservaHotelFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReservaHotelFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
