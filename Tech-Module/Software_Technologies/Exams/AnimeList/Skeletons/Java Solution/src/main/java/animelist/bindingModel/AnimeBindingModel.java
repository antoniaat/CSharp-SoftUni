package animelist.bindingModel;

public class AnimeBindingModel {

    private Integer rating;

    private String name;

    private String description;

    private String watched;

    public AnimeBindingModel() {
    }

    public Integer getRating() {
        return rating;
    }

    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }

    public String getWatched() {
        return watched;
    }

    public void setRating(Integer rating) {
        this.rating = rating;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public void setWatched(String watched) {
        this.watched = watched;
    }
}
