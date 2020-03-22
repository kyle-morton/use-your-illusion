import { Component, OnInit } from '@angular/core';
import { TeamService } from '../../../services';
import { TeamViewModel } from '../../../view-models';
import { ActivatedRoute } from '@angular/router';
import {Location} from '@angular/common';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-team-details',
  templateUrl: './team-details.component.html',
  styleUrls: ['./team-details.component.css']
})
export class TeamDetailsComponent implements OnInit {

  private id: string;
  public team: TeamViewModel;

  constructor(
    private teamService: TeamService, 
    private activatedRoute: ActivatedRoute, 
    private location: Location,
    private toastr: ToastrService
  ) { }

  ngOnInit() {
    this.id = this.activatedRoute.snapshot.params.id;
    if (!this.id) {
      this.location.back();
    }

    this.teamService.get<TeamViewModel>(this.id)
    .toPromise()
    .then(result => {
      this.team = result;
    })
    .catch(err => {
      console.error(err);
      this.toastr.error('Unable to get team');
    });
  }

  public Save() {
    this.teamService.put<TeamViewModel>(this.team, this.id)
    .toPromise()
    .then(result => {
      this.team = result;
      this.toastr.success('changes saved!');
    })
    .catch(err => {
      console.error(err);
      this.toastr.error('Unable to save changes');
    });
  }

}
