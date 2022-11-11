import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddGdReportComponent } from './add-gdreport.component';

describe('AddGdReportComponent', () => {
  let component: AddGdReportComponent;
  let fixture: ComponentFixture<AddGdReportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddGdReportComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddGdReportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
