import * as React from "react";

const MontyHallProblem = (props) => {
  const INITIAL_STATE = {
    numberOfSimulations: "",
    changeSelectedDoor: "false",
  };

  const [form, setForm] = React.useState(INITIAL_STATE);

  const handleChange = (event) => {
    setForm({
      ...form,
      [event.target.name]: event.target.value,
    });
    console.log(form);
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    alert(form.numberOfSimulations + " " + form.changeSelectedDoor);

    setForm(INITIAL_STATE);
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <label>
          Number of Games to simulate :
          <input
            type="text"
            name="numberOfSimulations"
            onChange={handleChange}
            value={form.numberOfSimulations}
          />
        </label>
        <div>
          <input
            type="radio"
            id="dontChange"
            name="changeSelectedDoor"
            value="false"
            checked={form.changeSelectedDoor === "false"}
            onChange={handleChange}
          />
            <label>Dont Change</label>
          <input
            type="radio"
            id="change"
            name="changeSelectedDoor"
            value="true"
            checked={form.changeSelectedDoor === "true"}
            onChange={handleChange}
          />
            <label>Change</label>
        </div>
        <input type="submit" value="Submit" />
      </form>
    </div>
  );
};

export default MontyHallProblem;
