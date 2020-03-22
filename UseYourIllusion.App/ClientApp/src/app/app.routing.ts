import { HomeComponent, TeamListComponent, TeamDetailsComponent } from "./components";
import { AuthorizeGuard } from "src/auth/authorize.guard";

export const routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'teams', canActivate: [AuthorizeGuard], children: [
        { path: '', component: TeamListComponent },
        { path: ':id', component: TeamDetailsComponent }
      ]
    },
  ]