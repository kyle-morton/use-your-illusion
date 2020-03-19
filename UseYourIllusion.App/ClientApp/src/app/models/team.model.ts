import { Player, Manager, Base } from ".";

export interface Team extends Base {
  Name: string;
  Location: string;
  Players: [Player];
  Manager: Manager;
}
