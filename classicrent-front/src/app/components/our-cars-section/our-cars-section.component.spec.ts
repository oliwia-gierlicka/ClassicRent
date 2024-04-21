import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OurCarsSectionComponent } from './our-cars-section.component';

describe('OurCarsSectionComponent', () => {
  let component: OurCarsSectionComponent;
  let fixture: ComponentFixture<OurCarsSectionComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [OurCarsSectionComponent]
    });
    fixture = TestBed.createComponent(OurCarsSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
