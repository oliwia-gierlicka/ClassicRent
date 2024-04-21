import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-welcome-section',
  templateUrl: './welcome-section.component.html',
  styleUrls: ['./welcome-section.component.scss']
})
export class WelcomeSectionComponent {

  constructor(private router: Router) {}

  signIn() {
    this.router.navigateByUrl('/sign-in');
  }

}
